#include <stdio.h>
#include <stdlib.h>

void display( void ); // refresh the board
void BOARD_init( void ); // generate a new board
void block_init( int piece, int rotation ); // generate a new block
void block_fall( void ); // make the block fall
void block_turn( void );
void block_left( void );
void block_right( void );
void block_rotate( int cp, int cr );
int can_fall( void ); // check if the block can fall
int can_left( void );
int can_right( void );
int can_rotate( int cp, int cr );
void del_lines( void ); // delete full lines

char BOARD[ 21 ][ 12 ] = {0}; // 20x10 without borders
char PIECES[ 7 ][ 4 ][ 4 ][ 4 ] = // 7 kinds, 4 rotations, stored in 4x4
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
}; // end PIECES

void display( void )
{
	int i, j; // counter
	system( "CLS" ); // refresh the screen
	printf( "\n" );
	for ( i = 0; i < 20; i++ ) {
		printf( "　　　" );
		for ( j = 0; j < 12; j++ ) {
			if ( j == 0 ) printf( "│" ); // print left border
			else if ( j == 11 ) {
				printf( "│" ); // print right border
				if ( i == 1 ) printf( "　　俄羅斯方塊 ver1.00 by 郭家銍"  );
				else if ( i == 4 ) printf( "　　Bug1. 未解決定時落下與等候輸入之衝突" );
				else if ( i == 5 ) printf( "　　      必須透過按鍵輸入使程式繼續執行" );
				else if ( i == 7 ) printf( "　　Bug2. 未解決輸入字串的尾端多餘之\"\\n\"" );
				else if ( i == 8 ) printf( "　　      任何按鍵輸入都會使方塊落下一格" );
				else if ( i == 10 ) printf( "　　Bug3. 未解決函數 getche() 之輸入回顯" );
				else if ( i == 11 ) printf( "　　      導致按鍵輸入會出現在畫面中一瞬" );
				else if ( i == 13 ) printf( "　　〈操作說明〉※須切換至英文輸入" );
				else if ( i == 15 ) printf( "　　Enter: 下落一格　　S: 下落兩格" );
				else if ( i == 17 ) printf( "　　A: 左移　　　　　　D: 右移" );
				else if ( i == 19 ) printf( "　　W: 旋轉" );
				printf( "\n" );
			} else {
				if ( BOARD[ i ][ j ] == 0 ) printf( "　" );
				else if ( BOARD[ i ][ j ] == 1 || BOARD[ i ][ j ] == 2 ) printf( "＊" );
				else if ( BOARD[ i ][ j ] == 3 ) printf( "＃" );
			} // end else
		} // end for
	} // end for
	printf( "　　　└──────────┘" ); // print bottom border
}

void BOARD_init( void )
{
	int i, j;
	for ( i = 0; i < 21; i++ )
		for ( j = 0; j < 12; j++ ) {
			if ( i == 20 ) BOARD[ i ][ j ] = 4;
			else if ( j == 0 || j == 11 ) BOARD[ i ][ j ] = 4;
			else BOARD[ i ][ j ] = 0;
		}
	display();
}

void block_init( int piece, int rotation )
{
	int i, j;
	for ( i = 0; i < 4; i++)
		for ( j = 0; j < 4; j++)
			if ( BOARD[ i ][ j + 3 ] == 0 )
				BOARD[ i ][ j + 3 ] = PIECES[ piece ][ rotation ][ i ][ j ];
	display();
}

int can_fall( void )
{
	int i, j;
	for ( i = 19; i >= 0 ; i-- ) { 
		for ( j = 1; j < 11; j++ ) {
			if ( BOARD[ i ][ j ] >= 1 && BOARD[ i ][ j ] <= 2  && BOARD[ i + 1 ][ j ] > 2 ) return 0;
		}
	}
	return 1;
}

void block_fall( void )
{
	int i, j;
	for ( i = 19; i >= 0 ; i-- ) { 
		for ( j = 1; j < 11; j++ ) {
			if ( BOARD[ i ][ j ] == 1 || BOARD[ i ][ j ] == 2 ) {
				BOARD[ i + 1 ][ j ] = BOARD[ i ][ j ]; 	// replace the next line with current line
				BOARD[ i ][ j ] = 0; // clean the current line
			}
		}
	} 
	display();
}

void block_turn( void )
{
	int i, j;
	for ( i = 19; i >= 0 ; i-- ) { 
		for ( j = 1; j < 11; j++ ) {
			if ( BOARD[ i ][ j ] == 1 || BOARD[ i ][ j ] == 2 ) BOARD[ i ][ j ] = 3;
		} 
	}
	display();
}

int can_left( void )
{
	int i, j;
	for ( i = 19; i >= 0 ; i-- ) { 
		for ( j = 1; j < 11; j++ ) {
			if ( BOARD[ i ][ j ] >= 1 && BOARD[ i ][ j ] <= 2 && BOARD[ i ][ j - 1 ] > 2 ) return 0;
		}
	}
	return 1;
}

void block_left( void )
{
	int i, j;
	for ( i = 19; i >= 0 ; i-- ) { 
		for ( j = 1; j < 11; j++ ) {
			if ( BOARD[ i ][ j ] == 1 || BOARD[ i ][ j ] == 2 ) {
				BOARD[ i ][ j - 1 ] = BOARD[ i ][ j ];
				BOARD[ i ][ j ] = 0;
			}
		}
	} 
	display();
}

int can_right( void )
{
	int i, j;
	for ( i = 19; i >= 0 ; i-- ) { 
		for ( j = 10; j > 0; j-- ) {
			if ( BOARD[ i ][ j ] >= 1 && BOARD[ i ][ j ] <= 2 && BOARD[ i ][ j + 1 ] > 2 ) return 0;
		}
	}
	return 1;
}

void block_right( void )
{
	int i, j;
	for ( i = 19; i >= 0 ; i-- ) { 
		for ( j = 10; j > 0; j-- ) {
			if ( BOARD[ i ][ j ] == 1 || BOARD[ i ][ j ] == 2 ) {
				BOARD[ i ][ j + 1 ] = BOARD[ i ][ j ];
				BOARD[ i ][ j ] = 0;
			}
		}
	} 
	display();
}

int can_rotate( int cp, int cr )
{
	int i, j, core_i, core_j;
	if ( cp == 0 ) return 0; // if current piece is O, return false
	for ( i = 19; i >= 0 ; i-- ) { // search the piece core
		for ( j = 1; j < 11; j++ ) {
			if ( BOARD[ i ][ j ] == 2 ) {
				core_i = i;
				core_j = j;
				break;
			} // end if
		} // end for
	} // end for
	if ( cp == 1 ) { // if current piece is I, should detect 4x4
		for ( i = core_i - 1; i <= core_i + 2; i++ ) {
			for ( j = core_j - 2; j <= core_j + 1; j++ ) {
				if ( BOARD[ i ][ j ] > 2 ) return 0;
			} // end for
		} // end for
		return 1;
	} else { // other piece, should detect 3x3
		for ( i = core_i - 1; i <= core_i + 1; i++ ) {
			for ( j = core_j - 1; j <= core_j + 1; j++ ) {
				if ( BOARD[ i ][ j ] > 2 ) return 0;
			} // end for
		} // end for
		return 1;
	} // end else
}

void block_rotate( int cp, int cr )
{
	int i, j, core_i, core_j;
	for ( i = 19; i >= 0 ; i-- ) { // search the piece core
		for ( j = 1; j < 11; j++ ) {
			if ( BOARD[ i ][ j ] == 2 ) {
				core_i = i;
				core_j = j;
				break;
			} // end if
		} // end for
	} // end for
	if ( cp == 1 ) { // if current piece is I , overwrite 4x4
		for ( i = core_i - 1; i <= core_i + 2; i++ ) {
			for ( j = core_j - 2; j <= core_j + 1; j++ ) {
				BOARD[ i ][ j ] = PIECES[ cp ][ cr ][ i - core_i + 1 ][ j - core_j + 2 ];
			} // end for
		} // end for
	} else { // other piece except O, overwrite 3x3
		for ( i = core_i - 1; i <= core_i + 1; i++ ) {
			for ( j = core_j - 1; j <= core_j + 1; j++ ) {
				BOARD[ i ][ j ] = PIECES[ cp ][ cr ][ i - core_i + 1 ][ j - core_j + 2 ];
			} // end for
		} // end for
	} // end else
}

void del_lines( void )
{
	int i, j, d, del; // counter of height, width, delete or not, which row to start delete
	int rows = 0; // row number of del lines
	for ( i = 19; i >= 0 ; i-- ) {
		d = 1;
		for ( j = 1; j < 11; j++ ) {
			if ( BOARD[ i ][ j ] != 3 ) d = 0;
		} // end for
		if ( rows > 0 && d == 0 ) break;
		else {
			rows += d;
			del = i;
		} // end else
	} // end for
	del = del + rows - 1;
	for ( i = del; i >= rows ; i-- ) {
		for ( j = 1; j < 11; j++ ) {
			BOARD[ i ][ j ] = BOARD[ i - rows ][ j ]; 
		} // end for
	} 
	display();
}
