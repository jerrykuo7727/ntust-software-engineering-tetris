using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Controller
{
    string currentState = "gameState";
    int cp, cr, np, nr; // declare current piece/rotation and next
    int block_falling = 0;
    int fuck;//if use model and view then can delete

    Random rd1 = new Random();

    public Controller()
    {
        // model = new Model();
        // view = new Tetris.View();
    }

    void UserHasInput()
    {
        char input;
        input = '1';//view.input;
        if (currentState == "gameOverState")
        {
            if (input == 'y')
            {
                //model.BOARD_init();
                np = rd1.Next(7);
                nr = rd1.Next(4);
                //model.total_del = 0;
                //model.difficulty = 1;
                //model.speed = 1000;
                currentState = "gameState";

            }
            else if (input == 'n')
            {
                //gameEnd();// let the game end
            }
            else
            {
                //view.gameover();
            }
        }
        else if (currentState == "gameState")
        {

            switch (input)
            {
                case 's':
                    if (can_fall() == 1) fuck = 1;//model.block_fall();

                    break;

                case 'a':
                    if (can_left() == 1) fuck = 1;//model.block_left();

                    break;

                case 'd':
                    if (can_right() == 1) fuck = 1;//model.block_right();

                    break;

                case 'w': // counter clockwise 
                    if (can_rotate(cp, cr, 1) == 1)
                    {
                        cr = (cr + 1) % 4; // rotate the piece
                                           //model.block_rotate(cp, cr); // overwrite with the rotated piece
                    }
                    break;

                case 'e': // clockwise
                    if (can_rotate(cp, cr, -1) == 1)
                    {
                        if (cr == 0) cr = 3;
                        else cr -= 1; // rotate the piece
                                      //model.block_rotate(cp, cr); // overwrite with the rotated piece
                    } // end if
                    break;

                case ' ':
                    while (can_fall() == 1) fuck = 1;//model.block_land();

                    //view.display();

                    break;
            } // end switch
            if (can_fall() == 0)
            {
                //model.block_turn(); // turn falling block into piling block
                //model.del_lines();
                block_falling = 0;
            }

        }
    }

    static void main()
    {
        Controller controller;
        //controller.gameStart();
    }

    void gameStart()
    {

        np = rd1.Next(7);
        nr = rd1.Next(4);

        //model.Board_Init();
        while (1 == 1)
        { // looping eternally

            if (block_falling == 0 && currentState == "gameState")
            { // if block piling, update board and new block
                cp = np; // replace current piece with next piece
                cr = nr;
                np = rd1.Next(7);
                nr = rd1.Next(4);
                if (isgameover(cp, cr) == 1)
                {
                    currentState = "gameOverState";
                    //view.gameover();

                } // end if
                else
                {
                    //model.add_block(cp, cr);
                    block_falling = 1;
                }
                  

            }// end if
        }


    }

    int can_fall()
    {
        int i, j;
        for (i = 19; i >= 0; i--)
        {
            for (j = 1; j < 11; j++)
            {
                if (1==1/*BOARD[i][j] >= 1 && BOARD[i][j] <= 2 && BOARD[i + 1][j] > 2*/) return 0;
            }
        }
        return 1;
    }

    int can_left()
    {
        int i, j;
        for (i = 19; i >= 0; i--)
        {
            for (j = 1; j < 11; j++)
            {
                if (1==1/*BOARD[i][j] >= 1 && BOARD[i][j] <= 2 && BOARD[i][j - 1] > 2*/) return 0;
            }
        }
        return 1;
    }

    int can_right()
    {
        int i, j;
        for (i = 19; i >= 0; i--)
        {
            for (j = 10; j > 0; j--)
            {
                if (1==1/*BOARD[i][j] >= 1 && BOARD[i][j] <= 2 && BOARD[i][j + 1] > 2*/) return 0;
            }
        }
        return 1;
    }

    int can_rotate(int cp, int cr, int clockwise)
    {
        if (cr == 4 && clockwise == 1) cr = -1;
        if (cr == 0 && clockwise == -1) cr = 5;
        int i, j, core_i=0, core_j=0, ti, tj;
        if (cp == 0) return 0; // if current piece is O, return false
        for (i = 19; i >= 0; i--)
        { // search the piece core
            for (j = 1; j < 11; j++)
            {
                if (1==1/*BOARD[i][j] == 2*/)
                {
                    core_i = i;
                    core_j = j;
                    break;
                } // end if
            } // end for
        } // end for
        if (cp == 1)
        { // if current piece is I, detect 4x4
            for (i = core_i - 1; i <= core_i + 2; i++)
            {
                for (j = core_j - 2; j <= core_j + 1; j++)
                {
                    if (1==1/*BOARD[i][j] > 2*/) return 0;
                } // end for
            } // end for
            return 1;
        }
        else if (cp == 6)
        { // else if current piece is T, should detect 3x3
            for (i = core_i - 1, ti = 0; i <= core_i + 1; i++, ti++)
            {
                for (j = core_j - 1, tj = 1; j <= core_j + 1; j++, tj++)
                {
                    if (1==1/*PIECES[cp][cr + clockwise][ti][tj] > 0 && BOARD[i][j] > 2*/) return 0; // detect rule: T spin
                } // end for
            } // end for
            return 1;
        }
        else
        { // other pieces, detect 3x3
            for (i = core_i - 1; i <= core_i + 1; i++)
            {
                for (j = core_j - 1; j <= core_j + 1; j++)
                {
                    if (1==1/*BOARD[i][j] > 2*/) return 0;
                } // end for
            } // end for
            return 1;
        } // end else
    }

    int isgameover(int piece, int rotation)
    {
        int i, j; // counter
        for (i = 0; i < 4; i++)
            for (j = 0; j < 4; j++)
                if (1==1/*BOARD[i][j + 3] == 3 && PIECES[piece][rotation][i][j] >= 1*/)
                    return 1;
        return 0;
    }
}

