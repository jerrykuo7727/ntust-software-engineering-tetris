public class Model
{
    //Types of the tetris model
    //0 is sapce,1 is block, 2 is block and the rotate core
    public readonly int[,,,] PIECES = new int[7, 4, 4, 4]
    {
        { // O
	        {
                { 0, 0, 0, 0 },
                { 0, 1, 2, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 0, 0 },
                { 0, 1, 2, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 0, 0 },
                { 0, 1, 2, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 0, 0 },
                { 0, 1, 2, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 0, 0 }
            }
        }, // end O
	    { // I
			{
                { 0, 0, 0, 0 },
                { 1, 1, 2, 1 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 1, 0 },
                { 0, 0, 2, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 1, 0 }
            },
            {
                { 0, 0, 0, 0 },
                { 1, 1, 2, 1 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 1, 0 },
                { 0, 0, 2, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 1, 0 }
            }
        }, // end I
		{ // S
			{
                { 0, 0, 0, 0 },
                { 0, 0, 2, 1 },
                { 0, 1, 1, 0 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 1, 0 },
                { 0, 0, 2, 1 },
                { 0, 0, 0, 1 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 0, 0 },
                { 0, 0, 2, 1 },
                { 0, 1, 1, 0 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 1, 0 },
                { 0, 0, 2, 1 },
                { 0, 0, 0, 1 },
                { 0, 0, 0, 0 }
            }
        }, // end S
		{ // Z
			{
                { 0, 0, 0, 0 },
                { 0, 1, 2, 0 },
                { 0, 0, 1, 1 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 0, 1 },
                { 0, 0, 2, 1 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 0, 0 },
                { 0, 1, 2, 0 },
                { 0, 0, 1, 1 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 0, 1 },
                { 0, 0, 2, 1 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 0 }
            }
        }, // end Z
		{ // L
			{
                { 0, 0, 0, 0 },
                { 0, 1, 2, 1 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 1, 0 },
                { 0, 0, 2, 0 },
                { 0, 0, 1, 1 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 0, 1 },
                { 0, 1, 2, 1 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 1, 1, 0 },
                { 0, 0, 2, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 0 }
            }
        }, // end L
		{ // J
			{
                { 0, 0, 0, 0 },
                { 0, 1, 2, 1 },
                { 0, 0, 0, 1 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 1, 1 },
                { 0, 0, 2, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 1, 0, 0 },
                { 0, 1, 2, 1 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 1, 0 },
                { 0, 0, 2, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 0, 0 }
            }
        }, // end J
		{ // T
			{
                { 0, 0, 0, 0 },
                { 0, 1, 2, 1 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 1, 0 },
                { 0, 0, 2, 1 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 1, 0 },
                { 0, 1, 2, 1 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            },
            {
                { 0, 0, 1, 0 },
                { 0, 1, 2, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 0 }
            }
        } // end T
	};
    public int grade = 0;
    public int total_del; // total of deleted lines
    public int difficulty, speed;
    public int[,] Board; // 20x10 without borders

    public Model()
    {
        total_del = 0;
        difficulty = 1;
        speed = 1000;
        Board = new int[21, 12];
        Board.Initialize(); // the default value of int in C# is 0
        BoardInit();
    }

    /* On board, 0: space, 1: falling block, 2: rotation core, 3: piling block, 4: border */
    //initial the board = 0, and the boarder = 4
    public void BoardInit()
    {
        for (int i = 0; i < 21; i++)
            for (int j = 0; j < 12; j++)
            {
                if (i == 20) Board[i, j] = 4;
                else if (j == 0 || j == 11) Board[i, j] = 4;
                else Board[i, j] = 0;
            }
    }

    //add a new block in the board
    public void add_block(int piece, int rotation)//block_init
    {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                if (Board[i, j + 3] == 0)
                    Board[i, j + 3] = PIECES[piece, rotation, i, j];
    }


    public void block_left()
    {
        for (int i = 19; i >= 0; i--)
        {
            for (int j = 1; j < 11; j++)
            {
                if (Board[i, j] == 1 || Board[i, j] == 2)
                {
                    Board[i, j - 1] = Board[i, j];
                    Board[i, j] = 0;
                }
            }
        }
    }

    public void block_right()
    {
        for (int i = 19; i >= 0; i--)
        {
            for (int j = 10; j > 0; j--)
            {
                if (Board[i, j] == 1 || Board[i, j] == 2)
                {
                    Board[i, j + 1] = Board[i, j];
                    Board[i, j] = 0;
                }
            }
        }
    }

    public void block_rotate(int cp, int cr)
    {
        int core_i = 0, core_j = 0;
        for (int i = 19; i >= 0; i--)
        { // search the piece core
            for (int j = 1; j < 11; j++)
            {
                if (Board[i, j] == 2)
                {
                    core_i = i;
                    core_j = j;
                    break;
                } // end if
            } // end for
        } // end for
        if (cp == 1)
        { // if current piece is I , overwrite 4x4
            for (int i = core_i - 1; i <= core_i + 2; i++)
            {
                for (int j = core_j - 2; j <= core_j + 1; j++)
                {
                    Board[i, j] = PIECES[cp, cr, i - core_i + 1, j - core_j + 2];
                } // end for
            } // end for
        }
        else if (cp == 6)
        { // if current piece is T, overwrite cross only
            for (int i = core_i - 1, ti = 0; i <= core_i + 1; i++, ti++)
            {
                for (int j = core_j - 1, tj = 1; j <= core_j + 1; j++, tj++)
                {
                    if (PIECES[cp, cr, ti, tj] > 0 || Board[i, j] == 1)
                        Board[i, j] = PIECES[cp, cr, i - core_i + 1, j - core_j + 2];
                } // end for
            } // end for
        }
        else
        { // other piece except O, overwrite 3x3
            for (int i = core_i - 1; i <= core_i + 1; i++)
            {
                for (int j = core_j - 1; j <= core_j + 1; j++)
                {
                    Board[i, j] = PIECES[cp, cr, i - core_i + 1, j - core_j + 2];
                } // end for
            } // end for
        } // end else
    }

    public void block_land()
    {
        for (int i = 19; i >= 0; i--)
        {
            for (int j = 1; j < 11; j++)
            {
                if (Board[i, j] == 1 || Board[i, j] == 2)
                {
                    Board[i + 1, j] = Board[i, j];  // replace the next line with current line
                    Board[i, j] = 0; // clean the current line
                }
            }
        }
    }

	public void block_fall()
	{
		for (int i = 19; i >= 0; i--)
		{
			for (int j = 1; j < 11; j++)
			{
				if (Board[i,j] == 1 || Board[i,j] == 2)
				{
					Board[i + 1,j] = Board[i,j];  // replace the next line with current line
					Board[i,j] = 0; // clean the current line
				}
			}
		}
	}

	// turn falling block into piling block
	public void block_turn()
	{
		for (int i = 19; i >= 0; i--)
		{
			for (int j = 1; j < 11; j++)
			{
				//turn it to piling block
				if (Board[i,j] == 1 || Board[i,j] == 2) Board[i,j] = 3;
			}
		}
	}

    public void del_lines()
    {
        int d = 1, del = 0; // counter of height, width, delete or not, which row to start delete
        int rows = 0; // row number of del lines
        for (int i = 19; i >= 0; i--)
        {
            d = 1;
            for (int j = 1; j < 11; j++)
            {
                if (Board[i,j] != 3) d = 0;
            } // end for
            if (rows > 0 && d == 0) break;
            else
            {
                rows += d;
                del = i;
            } // end else
        } // end for
        del = del + rows - 1;
        for (int i = del; i >= rows; i--)
        {
            for (int j = 1; j < 11; j++)
            {
                Board[i, j] = Board[i - rows, j];
            } // end for
        }
        total_del += rows;
        if (total_del < 5)
        {
            difficulty = 1;
            speed = 1000;
            grade += rows * 500;
        }
        else if (total_del < 10)
        {
            difficulty = 2;
            speed = 800;
            grade += rows * 1000;
        }
        else if (total_del < 15)
        {
            difficulty = 3;
            speed = 600;
            grade += rows * 2000;
        }
        else if (total_del < 20)
        {
            difficulty = 4;
            speed = 400;
            grade += rows * 4000;
        }
        else if (total_del < 25)
        {
            difficulty = 5;
            speed = 200;
            grade += rows * 10000;
        } // end else if
    }
}
