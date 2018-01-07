
class Model
{
	/* On board, 0: space, 1: falling block, 2: rotation core, 3: piling block, 4: border */
	//initial the board = 0, and the boarder = 4
	public void BOARD_init()
	{
		int i, j;
		for (i = 0; i < 21; i++)
			for (j = 0; j < 12; j++)
			{
				if (i == 20) BOARD[i,j] = 4;
				else if (j == 0 || j == 11) BOARD[i,j] = 4;
				else BOARD[i,j] = 0;
			}

		display();
	}
	//add a new block in the board
	public void add_block(int piece, int rotation)//block_init
	{
		int i, j;
		for (i = 0; i < 4; i++)
			for (j = 0; j < 4; j++)
				if (BOARD[i,j + 3] == 0)
					BOARD[i,j + 3] = PIECES[piece,rotation,i,j];

		display();
	}

	void block_fall()
	{
		int i, j;
		for (i = 19; i >= 0; i--)
		{
			for (j = 1; j < 11; j++)
			{
				if (BOARD[i,j] == 1 || BOARD[i,j] == 2)
				{
					BOARD[i + 1,j] = BOARD[i,j];  // replace the next line with current line
					BOARD[i,j] = 0; // clean the current line
				}
			}
		}
		display();
	}

	// turn falling block into piling block
	void block_turn()
	{
		int i, j;
		for (i = 19; i >= 0; i--)
		{
			for (j = 1; j < 11; j++)
			{
				if (BOARD[i,j] == 1 || BOARD[i,j] == 2) BOARD[i,j] = 3;
			}
		}
		display();
	}

	void block_left( );
	void block_right( );
	void block_rotate(int cp, int cr);
	void block_land();
	


	

	public int total_del = 0, difficulty = 1, speed = 1000; // total of deleted lines
	public int[,] BOARD = new int[21, 12] { 0 }; // 20x10 without borders

	//Types of the tetris model
	//0 is sapce,1 is block, 2 is block and the rotate core
	public int[,,,] PIECES = new int[7, 4, 4, 4]
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

}
