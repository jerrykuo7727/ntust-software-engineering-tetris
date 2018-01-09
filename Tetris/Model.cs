class Model
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
    public int total_del = 0, difficulty = 1; // total of deleted lines
    public int[,] BOARD; // 20x10 without borders

    public Model()
    {
        BOARD = new int[21, 12];
        BOARD.Initialize(); // the default value of int in C# is 0
    }

    /* On board, 0: space, 1: falling block, 2: rotation core, 3: piling block, 4: border */
    //initial the board = 0, and the boarder = 4
    public void BOARD_init()
    {
        for (int i = 0; i < 21; i++)
            for (int j = 0; j < 12; j++)
            {
                if (i == 20) BOARD[i, j] = 4;
                else if (j == 0 || j == 11) BOARD[i, j] = 4;
                else BOARD[i, j] = 0;
            }
    }

    //add a new block in the board
    public void add_block(int piece, int rotation)//block_init
    {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                if (BOARD[i, j + 3] == 0)
                    BOARD[i, j + 3] = PIECES[piece, rotation, i, j];
    }


    void block_left()
    {
        for (int i = 19; i >= 0; i--)
        {
            for (int j = 1; j < 11; j++)
            {
                if (BOARD[i, j] == 1 || BOARD[i, j] == 2)
                {
                    BOARD[i, j - 1] = BOARD[i, j];
                    BOARD[i, j] = 0;
                }
            }
        }
    }

    void block_right()
    {
        for (int i = 19; i >= 0; i--)
        {
            for (int j = 10; j > 0; j--)
            {
                if (BOARD[i, j] == 1 || BOARD[i, j] == 2)
                {
                    BOARD[i, j + 1] = BOARD[i, j];
                    BOARD[i, j] = 0;
                }
            }
        }
    }

    void block_rotate(int cp, int cr)
    {
        int core_i = 0, core_j = 0;
        for (int i = 19; i >= 0; i--)
        { // search the piece core
            for (int j = 1; j < 11; j++)
            {
                if (BOARD[i, j] == 2)
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
                    BOARD[i, j] = PIECES[cp, cr, i - core_i + 1, j - core_j + 2];
                } // end for
            } // end for
        }
        else if (cp == 6)
        { // if current piece is T, overwrite cross only
            for (int i = core_i - 1, ti = 0; i <= core_i + 1; i++, ti++)
            {
                for (int j = core_j - 1, tj = 1; j <= core_j + 1; j++, tj++)
                {
                    if (PIECES[cp, cr, ti, tj] > 0 || BOARD[i, j] == 1)
                        BOARD[i, j] = PIECES[cp, cr, i - core_i + 1, j - core_j + 2];
                } // end for
            } // end for
        }
        else
        { // other piece except O, overwrite 3x3
            for (int i = core_i - 1; i <= core_i + 1; i++)
            {
                for (int j = core_j - 1; j <= core_j + 1; j++)
                {
                    BOARD[i, j] = PIECES[cp, cr, i - core_i + 1, j - core_j + 2];
                } // end for
            } // end for
        } // end else
    }

    void block_land()
    {
        for (int i = 19; i >= 0; i--)
        {
            for (int j = 1; j < 11; j++)
            {
                if (BOARD[i, j] == 1 || BOARD[i, j] == 2)
                {
                    BOARD[i + 1, j] = BOARD[i, j];  // replace the next line with current line
                    BOARD[i, j] = 0; // clean the current line
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
				if (BOARD[i,j] == 1 || BOARD[i,j] == 2)
				{
					BOARD[i + 1,j] = BOARD[i,j];  // replace the next line with current line
					BOARD[i,j] = 0; // clean the current line
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
				if (BOARD[i,j] == 1 || BOARD[i,j] == 2) BOARD[i,j] = 3;
			}
		}
	}
}
