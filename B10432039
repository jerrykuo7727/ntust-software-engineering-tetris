//model裡的void block_left(), void block_right(), void block_rotate()和void block_land()

void block_left()
		{
			int i, j;
			for (i = 19; i >= 0; i--)
			{
				for (j = 1; j < 11; j++)
				{
					if (BOARD[i, j] == 1 || BOARD[i, j] == 2)
					{
						BOARD[i, j - 1] = BOARD[i, j];
						BOARD[i, j] = 0;
					}
				}
			}
			display();
		}

		void block_right()
		{
			int i, j;
			for (i = 19; i >= 0; i--)
			{
				for (j = 10; j > 0; j--)
				{
					if (BOARD[i, j] == 1 || BOARD[i, j] == 2)
					{
						BOARD[i, j + 1] = BOARD[i, j];
						BOARD[i, j] = 0;
					}
				}
			}
			display();
		}

		void block_rotate(int cp, int cr)
		{
			int i, j, core_i, core_j, ti, tj;
			for (i = 19; i >= 0; i--)
			{ // search the piece core
				for (j = 1; j < 11; j++)
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
				for (i = core_i - 1; i <= core_i + 2; i++)
				{
					for (j = core_j - 2; j <= core_j + 1; j++)
					{
						BOARD[i, j] = PIECES[cp, cr, i - core_i + 1, j - core_j + 2];
					} // end for
				} // end for
			}
			else if (cp == 6)
			{ // if current piece is T, overwrite cross only
				for (i = core_i - 1, ti = 0; i <= core_i + 1; i++, ti++)
				{
					for (j = core_j - 1, tj = 1; j <= core_j + 1; j++, tj++)
					{
						if (PIECES[cp, cr, ti, tj] > 0 || BOARD[i, j] == 1)
							BOARD[i, j] = PIECES[cp, cr, i - core_i + 1, j - core_j + 2];
					} // end for
				} // end for
			}
			else
			{ // other piece except O, overwrite 3x3
				for (i = core_i - 1; i <= core_i + 1; i++)
				{
					for (j = core_j - 1; j <= core_j + 1; j++)
					{
						BOARD[i, j] = PIECES[cp, cr, i - core_i + 1, j - core_j + 2];
					} // end for
				} // end for
			} // end else
			display();
		}

		void block_land()
		{
			int i, j;
			for (i = 19; i >= 0; i--)
			{
				for (j = 1; j < 11; j++)
				{
					if (BOARD[i, j] == 1 || BOARD[i, j] == 2)
					{
						BOARD[i + 1, j] = BOARD[i, j];  // replace the next line with current line
						BOARD[i, j] = 0; // clean the current line
					}
				}
			}
		}
