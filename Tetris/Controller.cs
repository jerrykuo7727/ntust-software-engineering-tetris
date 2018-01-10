using System;
using Tetris;

public class Controller
{
    public string currentState = "gameState";
    private int cp, cr, np, nr; // declare current piece/rotation and next
    private bool block_falling;
    private Model model;
    private View view;
    private Random rd1;

    public Controller(Model _model, View _view)
    {
        model = _model;
        view = _view;
        rd1 = new Random(new System.DateTime().Second);
        block_falling = false;
        np = rd1.Next(7);
        nr = rd1.Next(4);
    }

    public void UserHasInput()
    {
        USERINPUT input = view.input;
        if (block_falling && currentState == "gameState")
        {
            if(!CanFall())
            {
                model.block_turn(); // turn falling block into piling block
                model.del_lines();
                block_falling = false;
            }
        }
        if (!block_falling)
        {
            // if block piling, update board and new block
            cp = np; // replace current piece with next piece
            cr = nr;
            np = rd1.Next(7);
            nr = rd1.Next(4);
            if (IsGameover(cp, cr))
            {
                currentState = "gameOverState";
            }
            else
            {
                model.add_block(cp, cr);
                block_falling = true;
            }
        }
        if (currentState == "gameOverState")
        {
            if (input == USERINPUT.RESTART)
            {
                model.BoardInit();
                np = rd1.Next(7);
                nr = rd1.Next(4);
                model.total_del = 0;
                model.difficulty = 1;
                currentState = "gameState";

            }
            else
            {
                // actually, do nothing. 
                // if user doesn't click any button, input is DOWN.
                // if user clicks the NO button, the button will call Application.Exit()
            }
        }
        else if (currentState == "gameState")
        {
            switch (input)
            {
                case USERINPUT.DOWN:
                    if (CanFall()) model.block_fall();

                    break;

                case USERINPUT.LEFT:
                    if (CanLeft()) model.block_left();

                    break;

                case USERINPUT.RIGHT:
                    if (CanRight()) model.block_right();

                    break;

                case USERINPUT.CCW_ROTATE: // counter clockwise 
                    if (CanRotate(cp, cr, 1))
                    {
                        cr = (cr + 1) % 4; // rotate the piece
                        model.block_rotate(cp, cr); // overwrite with the rotated piece
                    }
                    break;

                case USERINPUT.CW_ROTATE: // clockwise
                    if (CanRotate(cp, cr, -1))
                    {
                        if (cr == 0) cr = 3;
                        else cr -= 1; // rotate the piece
                        model.block_rotate(cp, cr); // overwrite with the rotated piece
                    } // end if
                    break;

                case USERINPUT.LAND:
                    while (CanFall()) model.block_land();
                    break;
            } // end switch
        }
    }

    bool CanFall()
    {
        int i, j;
        for (i = 19; i >= 0; i--)
        {
            for (j = 1; j < 11; j++)
            {
                if (model.Board[i, j] >= 1 && model.Board[i, j] <= 2 && model.Board[i + 1, j] > 2) return false;
            }
        }
        return true;
    }

    bool CanLeft()
    {
        int i, j;
        for (i = 19; i >= 0; i--)
        {
            for (j = 1; j < 11; j++)
            {
                if (model.Board[i, j] >= 1 && model.Board[i, j] <= 2 && model.Board[i, j - 1] > 2) return false;
            }
        }
        return true;
    }

    bool CanRight()
    {
        int i, j;
        for (i = 19; i >= 0; i--)
        {
            for (j = 10; j > 0; j--)
            {
                if (model.Board[i, j] >= 1 && model.Board[i, j] <= 2 && model.Board[i, j + 1] > 2) return false;
            }
        }
        return true;
    }

    bool CanRotate(int cp, int cr, int clockwise)
    {
        if (cr == 4 && clockwise == 1) cr = -1;
        if (cr == 0 && clockwise == -1) cr = 5;
        int core_i = 0, core_j = 0;
        if (cp == 0) return false; // if current piece is O, return false
        for (int i = 19; i >= 0; i--)
        { // search the piece core
            for (int j = 1; j < 11; j++)
            {
                if (model.Board[i, j] == 2)
                {
                    core_i = i;
                    core_j = j;
                    break;
                } // end if
            } // end for
        } // end for
        if (cp == 1)
        { // if current piece is I, detect 4x4
            for (int i = core_i - 1; i <= core_i + 2; i++)
            {
                for (int j = core_j - 2; j <= core_j + 1; j++)
                {
                    if (model.Board[i, j] > 2) return false;
                } // end for
            } // end for
            return true;
        }
        else if (cp == 6)
        { // else if current piece is T, should detect 3x3
            for (int i = core_i - 1, ti = 0; i <= core_i + 1; i++, ti++)
            {
                for (int j = core_j - 1, tj = 1; j <= core_j + 1; j++, tj++)
                {
                    int new_cr = cr + clockwise;
                    if (new_cr > 3) new_cr -= 3;
                    else if (new_cr < 0) new_cr += 3;
                    if (model.PIECES[cp, new_cr, ti, tj] > 0 && model.Board[i, j] > 2) return false; // detect rule: T spin
                } // end for
            } // end for
            return true;
        }
        else
        { // other pieces, detect 3x3
            for (int i = core_i - 1; i <= core_i + 1; i++)
            {
                for (int j = core_j - 1; j <= core_j + 1; j++)
                {
                    if (model.Board[i, j] > 2) return false;
                } // end for
            } // end for
            return true;
        } // end else
    }

    bool IsGameover(int piece, int rotation)
    {
        int i, j; // counter
        for (i = 0; i < 4; i++)
            for (j = 0; j < 4; j++)
                if (model.Board[i, j + 3] == 3 && model.PIECES[piece, rotation, i, j] >= 1)
                    return true;
        return false;
    }
}

