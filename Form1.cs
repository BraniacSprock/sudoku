namespace Sudoku_Çözücü
{
    public partial class Form1 : Form
    {
        string selected = "";
        public Form1()
        {
            InitializeComponent();
        }
        // Form1 sınıfının içine ekle
        private bool SolveSudoku(int[,] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] == 0)
                    {
                        for (int num = 1; num <= 9; num++)
                        {
                            if (IsSafe(board, row, col, num))
                            {
                                board[row, col] = num;
                                if (SolveSudoku(board))
                                    return true;
                                board[row, col] = 0;
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsSafe(int[,] board, int row, int col, int num)
        {
            for (int x = 0; x < 9; x++)
                if (board[row, x] == num || board[x, col] == num)
                    return false;

            int startRow = row - row % 3, startCol = col - col % 3;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[i + startRow, j + startCol] == num)
                        return false;

            return true;
        }

        private int[,] ReadBoard()
        {
            int[,] board = new int[9, 9];
            string[,] cells = {
        { A1, A2, A3, A4, A5, A6, A7, A8, A9 },
        { B1, B2, B3, B4, B5, B6, B7, B8, B9 },
        { C1, C2, C3, C4, C5, C6, C7, C8, C9 },
        { D1, D2, D3, D4, D5, D6, D7, D8, D9 },
        { E1, E2, E3, E4, E5, E6, E7, E8, E9 },
        { F1, F2, F3, F4, F5, F6, F7, F8, F9 },
        { G1, G2, G3, G4, G5, G6, G7, G8, G9 },
        { H1, H2, H3, H4, H5, H6, H7, H8, H9 },
        { J1, J2, J3, J4, J5, J6, J7, J8, J9 }
    };
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    board[i, j] = int.TryParse(cells[i, j], out int val) ? val : 0;
            return board;
        }

        private void WriteBoard(int[,] board)
        {
            var controls = new Control[,]
            {
        { a1, a2, a3, a4, a5, a6, a7, a8, a9 },
        { b1, b2, b3, b4, b5, b6, b7, b8, b9 },
        { c1, c2, c3, c4, c5, c6, c7, c8, c9 },
        { d1, d2, d3, d4, d5, d6, d7, d8, d9 },
        { e1, e2, e3, e4, e5, e6, e7, e8, e9 },
        { f1, f2, f3, f4, f5, f6, f7, f8, f9 },
        { g1, g2, g3, g4, g5, g6, g7, g8, g9 },
        { h1, h2, h3, h4, h5, h6, h7, h8, h9 },
        { j1, j2, j3, j4, j5, j6, j7, j8, j9 }
            };
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    controls[i, j].Text = board[i, j] == 0 ? "" : board[i, j].ToString();
        }

        string A1, A2, A3, A4, A5, A6, A7, A8, A9;
        string B1, B2, B3, B4, B5, B6, B7, B8, B9;
        string C1, C2, C3, C4, C5, C6, C7, C8, C9;
        string D1, D2, D3, D4, D5, D6, D7, D8, D9;
        string E1, E2, E3, E4, E5, E6, E7, E8, E9;
        string F1, F2, F3, F4, F5, F6, F7, F8, F9;
        string G1, G2, G3, G4, G5, G6, G7, G8, G9;
        string H1, H2, H3, H4, H5, H6, H7, H8, H9;
        string J1, J2, J3, J4, J5, J6, J7, J8, J9;

        private void Bir_Click(object sender, EventArgs e)
        {
            selected = "1";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            selected = "2";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            selected = "3";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            selected = "4";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            selected = "5";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            selected = "6";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            selected = "7";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            selected = "8";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            selected = "9";
        }

        private void a1_Click(object sender, EventArgs e)
        {
            a1.Text = selected;
            A1 = a1.Text;
        }

        private void a2_Click(object sender, EventArgs e)
        {
            a2.Text = selected;
            A2 = a2.Text;
        }

        private void a3_Click(object sender, EventArgs e)
        {
            a3.Text = selected;
            A3 = a3.Text;
        }

        private void a4_Click(object sender, EventArgs e)
        {
            a4.Text = selected;
            A4 = a4.Text;
        }

        private void a5_Click(object sender, EventArgs e)
        {
            a5.Text = selected;
            A5 = a5.Text;
        }

        private void a6_Click(object sender, EventArgs e)
        {
            a6.Text = selected;
            A6 = a6.Text;
        }

        private void a7_Click(object sender, EventArgs e)
        {
            a7.Text = selected;
            A7 = a7.Text;
        }

        private void a8_Click(object sender, EventArgs e)
        {
            a8.Text = selected;
            A8 = a8.Text;
        }

        private void a9_Click(object sender, EventArgs e)
        {
            a9.Text = selected;
            A9 = a9.Text;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            b1.Text = selected;
            B1 = b1.Text;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            b2.Text = selected;
            B2 = b2.Text;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            b3.Text = selected;
            B3 = b3.Text;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            b4.Text = selected;
            B4 = b4.Text;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            b5.Text = selected;
            B5 = b5.Text;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            b6.Text = selected;
            B6 = b6.Text;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            b7.Text = selected;
            B7 = b7.Text;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            b8.Text = selected;
            B8 = b8.Text;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            b9.Text = selected;
            B9 = b9.Text;
        }

        private void c1_Click(object sender, EventArgs e)
        {
            c1.Text = selected;
            C1 = c1.Text;
        }

        private void c2_Click(object sender, EventArgs e)
        {
            c2.Text = selected;
            C2 = c2.Text;
        }

        private void c3_Click(object sender, EventArgs e)
        {
            c3.Text = selected;
            C3 = c3.Text;
        }

        private void c4_Click(object sender, EventArgs e)
        {
            c4.Text = selected;
            C4 = c4.Text;
        }

        private void c5_Click(object sender, EventArgs e)
        {
            c5.Text = selected;
            C5 = c5.Text;
        }

        private void c6_Click(object sender, EventArgs e)
        {
            c6.Text = selected;
            C6 = c6.Text;
        }

        private void c7_Click(object sender, EventArgs e)
        {
            c7.Text = selected;
            C7 = c7.Text;
        }

        private void c8_Click(object sender, EventArgs e)
        {
            c8.Text = selected;
            C8 = c8.Text;
        }

        private void c9_Click(object sender, EventArgs e)
        {
            c9.Text = selected;
            C9 = c9.Text;
        }

        private void d1_Click(object sender, EventArgs e)
        {
            d1.Text = selected;
            D1 = d1.Text;
        }

        private void d2_Click(object sender, EventArgs e)
        {
            d2.Text = selected;
            D2 = d2.Text;
        }

        private void d3_Click(object sender, EventArgs e)
        {
            d3.Text = selected;
            D3 = d3.Text;
        }

        private void d4_Click(object sender, EventArgs e)
        {
            d4.Text = selected;
            D4 = d4.Text;
        }

        private void d5_Click(object sender, EventArgs e)
        {
            d5.Text = selected;
            D5 = d5.Text;
        }

        private void d6_Click(object sender, EventArgs e)
        {
            d6.Text = selected;
            D6 = d6.Text;
        }

        private void d7_Click(object sender, EventArgs e)
        {
            d7.Text = selected;
            D7 = d7.Text;
        }

        private void d8_Click(object sender, EventArgs e)
        {
            d8.Text = selected;
            D8 = d8.Text;
        }

        private void d9_Click(object sender, EventArgs e)
        {
            d9.Text = selected;
            D9 = d9.Text;
        }

        private void e1_Click(object sender, EventArgs e)
        {
            e1.Text = selected;
            E1 = e1.Text;
        }

        private void e2_Click(object sender, EventArgs e)
        {
            e2.Text = selected;
            E2 = e2.Text;
        }

        private void e3_Click(object sender, EventArgs e)
        {
            e3.Text = selected;
            E3 = e3.Text;
        }

        private void e4_Click(object sender, EventArgs e)
        {
            e4.Text = selected;
            E4 = e4.Text;
        }

        private void e5_Click(object sender, EventArgs e)
        {
            e5.Text = selected;
            E5 = e5.Text;
        }

        private void e6_Click(object sender, EventArgs e)
        {
            e6.Text = selected;
            E6 = e6.Text;
        }

        private void e7_Click(object sender, EventArgs e)
        {
            e7.Text = selected;
            E7 = e7.Text;
        }

        private void e8_Click(object sender, EventArgs e)
        {
            e8.Text = selected;
            E8 = e8.Text;
        }

        private void e9_Click(object sender, EventArgs e)
        {
            e9.Text = selected;
            E9 = e9.Text;
        }

        private void f1_Click(object sender, EventArgs e)
        {
            f1.Text = selected;
            F1 = f1.Text;
        }

        private void f2_Click(object sender, EventArgs e)
        {
            f2.Text = selected;
            F2 = f2.Text;
        }

        private void f3_Click(object sender, EventArgs e)
        {
            f3.Text = selected;
            F3 = f3.Text;
        }

        private void f4_Click(object sender, EventArgs e)
        {
            f4.Text = selected;
            F4 = f4.Text;
        }

        private void f5_Click(object sender, EventArgs e)
        {
            f5.Text = selected;
            F5 = f5.Text;
        }

        private void f6_Click(object sender, EventArgs e)
        {
            f6.Text = selected;
            F6 = f6.Text;
        }

        private void f7_Click(object sender, EventArgs e)
        {
            f7.Text = selected;
            F7 = f7.Text;
        }

        private void f8_Click(object sender, EventArgs e)
        {
            f8.Text = selected;
            F8 = f8.Text;
        }

        private void f9_Click(object sender, EventArgs e)
        {
            f9.Text = selected;
            F9 = f9.Text;
        }

        private void h1_Click(object sender, EventArgs e)
        {
            h1.Text = selected;
            H1 = h1.Text;
        }

        private void h2_Click(object sender, EventArgs e)
        {
            h2.Text = selected;
            H2 = h2.Text;
        }

        private void h3_Click(object sender, EventArgs e)
        {
            h3.Text = selected;
            H3 = h3.Text;
        }

        private void h4_Click(object sender, EventArgs e)
        {
            h4.Text = selected;
            H4 = h4.Text;
        }

        private void h5_Click(object sender, EventArgs e)
        {
            h5.Text = selected;
            H5 = h5.Text;
        }

        private void h6_Click(object sender, EventArgs e)
        {
            h6.Text = selected;
            H6 = h6.Text;
        }

        private void h7_Click(object sender, EventArgs e)
        {
            h7.Text = selected;
            H7 = h7.Text;
        }

        private void h8_Click(object sender, EventArgs e)
        {
            h8.Text = selected;
            H8 = h8.Text;
        }

        private void h9_Click(object sender, EventArgs e)
        {
            h9.Text = selected;
            H9 = h9.Text;
        }

        private void g1_Click(object sender, EventArgs e)
        {
            g1.Text = selected;
            G1 = g1.Text;
        }

        private void g2_Click(object sender, EventArgs e)
        {
            g2.Text = selected;
            G2 = g2.Text;
        }

        private void g3_Click(object sender, EventArgs e)
        {
            g3.Text = selected;
            G3 = g3.Text;
        }

        private void g4_Click(object sender, EventArgs e)
        {
            g4.Text = selected;
            G4 = g4.Text;
        }

        private void g5_Click(object sender, EventArgs e)
        {
            g5.Text = selected;
            G5 = g5.Text;
        }

        private void g6_Click(object sender, EventArgs e)
        {
            g6.Text = selected;
            G6 = g6.Text;
        }

        private void g7_Click(object sender, EventArgs e)
        {
            g7.Text = selected;
            G7 = g7.Text;
        }

        private void g8_Click(object sender, EventArgs e)
        {
            g8.Text = selected;
            G8 = g8.Text;
        }

        private void g9_Click(object sender, EventArgs e)
        {
            g9.Text = selected;
            G9 = g9.Text;
        }

        private void j1_Click(object sender, EventArgs e)
        {
            j1.Text = selected;
            J1 = j1.Text;
        }

        private void j2_Click(object sender, EventArgs e)
        {
            j2.Text = selected;
            J2 = j2.Text;
        }

        private void j3_Click(object sender, EventArgs e)
        {
            j3.Text = selected;
            J3 = j3.Text;
        }

        private void j4_Click(object sender, EventArgs e)
        {
            j4.Text = selected;
            J4 = j4.Text;
        }

        private void j5_Click(object sender, EventArgs e)
        {
            j5.Text = selected;
            J5 = j5.Text;
        }

        private void j6_Click(object sender, EventArgs e)
        {
            j6.Text = selected;
            J6 = j6.Text;
        }

        private void j7_Click(object sender, EventArgs e)
        {
            j7.Text = selected;
            J7 = j7.Text;
        }

        private void j8_Click(object sender, EventArgs e)
        {
            j8.Text = selected;
            J8 = j8.Text;
        }

        private void j9_Click(object sender, EventArgs e)
        {
            j9.Text = selected;
            J9 = j9.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] board = ReadBoard();
            if (SolveSudoku(board))
                WriteBoard(board);
            else
                MessageBox.Show("Çözüm bulunulamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
