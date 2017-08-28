using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Klocek
    {
        int[][] KlocekMiejsce { get; set; }
        private byte ksztalt { get; set; }
        private byte pozycja { get; set; }

        public static void Obrot_L(byte ksztalt, byte pozycja)
        {
            switch (ksztalt)
            {
                case 1: // L 
                    break;
                case 2: // odwrócone L
                    break;
                case 3: // T
                    break;
                case 4: // ----
                    break;
                case 5: // S
                    break;
                case 6: // odwrócone S
                    break;
                case 7: // KWADRAT
                    break;

            }
            ;
        }

        void zeruj()
        {
            for (int i = 0; i == 4; i++)
            {
                for (int j = 0; j == 4; j++)
                {
                    this.KlocekMiejsce[i][j] = 0;
                }
            }
            
        }

        public static void Obrot_P(byte ksztalt, byte pozycja)
        {
            switch (ksztalt)
            {
                case 1: // L 
                    break;
                case 2: // odwrócone L
                    break;
                case 3: // T
                    break;
                case 4: // ----
                    break;
                case 5: // S
                    break;
                case 6: // odwrócone S
                    break;

            }
        }

        // L

        //[ ][ ][x][ ]          [ ][ ][ ][ ]          [ ][ ][ ][ ]          [ ][ ][ ][ ]
        //[ ][ ][x][ ]          [ ][ ][ ][ ]          [ ][x][x][ ]          [ ][x][ ][ ]
        //[ ][x][x][ ]          [x][x][x][ ]          [ ][x][ ][ ]          [ ][x][x][x]
        //[ ][ ][ ][ ]          [ ][ ][x][ ]          [ ][x][ ][ ]          [ ][ ][ ][ ]

        void L_1()
        {
            this.pozycja = 1;
            this.zeruj();
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
        }

        void L_2()
        {
            this.pozycja = 2;
            this.zeruj();
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
        }

        void L_3()
        {
            this.pozycja = 3;
            this.zeruj();
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
        }

        void L_4()
        {
            this.pozycja = 4;
            this.zeruj();
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
        }



        //odwrócone L

        //[ ][x][ ][ ]          [ ][ ][ ][ ]          [ ][ ][ ][ ]          [ ][ ][ ][ ]
        //[ ][x][ ][ ]          [ ][ ][ ][x]          [ ][x][x][ ]          [ ][x][x][x]
        //[ ][x][x][ ]          [ ][x][x][x]          [ ][ ][x][ ]          [ ][x][ ][ ]
        //[ ][ ][ ][ ]          [ ][ ][ ][ ]          [ ][ ][x][ ]          [ ][ ][ ][ ]

        void L2_1()
        {
            this.pozycja = 1;
            this.zeruj();
            this.KlocekMiejsce[0][1] = 2;
            this.KlocekMiejsce[1][1] = 2;
            this.KlocekMiejsce[2][1] = 2;
            this.KlocekMiejsce[2][2] = 2;
        }

        void L2_2()
        {
            this.pozycja = 2;
            this.zeruj();
            this.KlocekMiejsce[1][3] = 2;
            this.KlocekMiejsce[2][1] = 2;
            this.KlocekMiejsce[2][2] = 2;
            this.KlocekMiejsce[2][3] = 2;
        }

        void L2_3()
        {
            this.pozycja = 3;
            this.zeruj();
            this.KlocekMiejsce[1][1] = 2;
            this.KlocekMiejsce[1][2] = 2;
            this.KlocekMiejsce[2][2] = 2;
            this.KlocekMiejsce[3][2] = 2;
        }

        void L2_4()
        {
            this.pozycja = 4;
            this.zeruj();
            this.KlocekMiejsce[1][1] = 2;
            this.KlocekMiejsce[1][2] = 2;
            this.KlocekMiejsce[1][3] = 2;
            this.KlocekMiejsce[2][1] = 2;
        }

        // T

        //[ ][ ][ ][ ]          [ ][ ][ ][ ]          [ ][ ][ ][ ]          [ ][ ][ ][ ]
        //[ ][x][x][x]          [ ][x][ ][ ]          [ ][ ][x][ ]          [ ][ ][x][ ]
        //[ ][ ][x][ ]          [ ][x][x][ ]          [ ][x][x][x]          [ ][x][x][ ]
        //[ ][ ][ ][ ]          [ ][x][ ][ ]          [ ][ ][ ][ ]          [ ][ ][x][ ]

        void T_1()
        {
            this.pozycja = 1;
            this.zeruj();
            this.KlocekMiejsce[1][1] = 3;
            this.KlocekMiejsce[1][2] = 3;
            this.KlocekMiejsce[2][2] = 3;
            this.KlocekMiejsce[1][3] = 3;
        }

        void T_2()
        {
            this.pozycja = 2;
            this.zeruj();
            this.KlocekMiejsce[1][1] = 3;
            this.KlocekMiejsce[1][2] = 3;
            this.KlocekMiejsce[2][2] = 3;
            this.KlocekMiejsce[1][3] = 3;
        }

        void T_3()
        {
            this.pozycja = 3;
            this.zeruj();
            this.KlocekMiejsce[1][2] = 3;
            this.KlocekMiejsce[2][1] = 3;
            this.KlocekMiejsce[2][2] = 3;
            this.KlocekMiejsce[2][3] = 3;
        }

        void T_4()
        {
            this.pozycja = 4;
            this.zeruj();
            this.KlocekMiejsce[1][2] = 3;
            this.KlocekMiejsce[2][1] = 3;
            this.KlocekMiejsce[2][2] = 3;
            this.KlocekMiejsce[3][2] = 3;
        }

        // ----

        //[ ][x][ ][ ]          [ ][ ][ ][ ]
        //[ ][x][ ][ ]          [ ][ ][ ][ ]
        //[ ][x][ ][ ]          [x][x][x][x]
        //[ ][x][ ][ ]          [ ][ ][ ][ ]

        void I_1()
        {
            this.pozycja = 1;
            this.zeruj();
            this.KlocekMiejsce[1][0] = 4;
            this.KlocekMiejsce[1][1] = 4;
            this.KlocekMiejsce[1][2] = 4;
            this.KlocekMiejsce[1][3] = 4;
        }

        void I_2()
        {
            this.pozycja = 2;
            this.zeruj();
            this.KlocekMiejsce[3][0] = 4;
            this.KlocekMiejsce[3][1] = 4;
            this.KlocekMiejsce[3][2] = 4;
            this.KlocekMiejsce[3][3] = 4;
        }


        // S

        //[ ][ ][ ][ ]          [ ][ ][ ][ ]
        //[ ][ ][x][x]          [ ][x][ ][ ]
        //[ ][x][x][ ]          [ ][x][x][ ]
        //[ ][ ][ ][ ]          [ ][ ][x][ ]

        void S_1()
        {
            this.pozycja = 1;
            this.zeruj();
            this.KlocekMiejsce[1][2] = 5;
            this.KlocekMiejsce[1][3] = 5;
            this.KlocekMiejsce[2][1] = 5;
            this.KlocekMiejsce[2][2] = 5;
        }

        void S_2()
        {
            this.pozycja = 2;
            this.zeruj();
            this.KlocekMiejsce[1][1] = 5;
            this.KlocekMiejsce[2][1] = 5;
            this.KlocekMiejsce[2][2] = 5;
            this.KlocekMiejsce[3][2] = 5;
        }

        // odwrócone S

        //[ ][ ][ ][ ]          [ ][ ][ ][ ]
        //[ ][x][x][ ]          [ ][ ][x][ ]
        //[ ][ ][x][x]          [ ][x][x][ ]
        //[ ][ ][ ][ ]          [ ][x][ ][ ]

        void S2_1()
        {
            this.pozycja = 1;
            this.zeruj();
            this.KlocekMiejsce[1][1] = 6;
            this.KlocekMiejsce[1][2] = 6;
            this.KlocekMiejsce[2][2] = 6;
            this.KlocekMiejsce[2][3] = 6;
        }

        void S2_2()
        {
            this.pozycja = 2;
            this.zeruj();
            this.KlocekMiejsce[1][2] = 6;
            this.KlocekMiejsce[2][1] = 6;
            this.KlocekMiejsce[2][2] = 6;
            this.KlocekMiejsce[3][1] = 6;
        }

        // Kwadrat

        //[ ][ ][ ][ ]
        //[ ][x][x][ ]
        //[ ][x][x][ ]
        //[ ][ ][ ][ ]

        void K_4()
        {
            this.pozycja = 1;
            this.zeruj();
            this.KlocekMiejsce[1][1] = 7;
            this.KlocekMiejsce[1][2] = 7;
            this.KlocekMiejsce[2][1] = 7;
            this.KlocekMiejsce[2][2] = 7;
        }


    }
}
