# CME1251_PBL1
Dokuz eylul university - Project based learning : Triangle Battleship Game
Project:  Triangle Battleship Game
The aim of the project is to develop a one-player game in which user creates a triangle battleship, calculating geometrical properties of the ship and surviving from a random shot. If the ship survives, the player gets a point which is the area of the ship. 

Game Playing Rules
1.	The game starts with a menu which includes five options: (i) entering ship location (ii) listing the properties of the ship, (iii) shooting at the ship, (iv) showing high score table, and (v) exit. 
2.	The shape of the ship is a triangle and it can only be placed in the first quadrant (x>0, y>0) of the Cartesian coordinate plane. The player will enter the coordinates of three vertices (named A, B, and C) of the triangle. The program should control the validity of the triangle.
3.	The game area is 30 * 12 units. The ship will be shown on the coordinate plane.
4.	The program should list the following properties about the battleship: 
Basic Properties:
(i)	The size of the ship (length of the edges)
(ii)	The perimeter of the ship	
(iii)	The area of the ship
(iv)	The angles of the ship
(v)	Median points of the ship (intersection of a median and a triangle edge)
(vi)	The centroid of the ship	

Advanced Properties:
(vii)	The length of the bisector of the point A
(viii)	The area of the inscribed and circumscribed circles
(ix)	The type of the ship
•	Equilateral, Isosceles, Scalene
•	Acute-angled, Right-angled, Obtuse-angled

5.	It will be a random shot. If it hits the ship, the ship sinks.
6.	If the ship survives, the player will get the point which is the area of the ship.
7.	At the end of the game, the program should print the high score table. If the player gets a score that is high enough to be on the table, the name of the player is entered and his/her score is shown on the table. 
If the player gets a score that is equal to a score in the table, the name of the player is placed under the old one.
The default score table is as follows:
	Name 			Score
	Nazan Kaya		60
	Ali Kurt			30
	Sibel Arslan		10	 
Sample Game  
- MENU -
 PLEASE SELECT FROM THE OPTIONS BELOW:
	1 – Enter ship location 
	2 – Ship info 
	3 – Shoot at the ship 
	4 – Show high score table
	5 – Exit
EXAMPLE 1
Please enter the location of the ship
A: (4,8)
B: (4,2)
C: (12,2)	EXAMPLE 2
Please enter the location of the ship
A: (8,4)
B: (12,12)
C: (16,4)

  12|                              
  11|                              
  10|                              
   9|                              
   8|   A                          
   7|                              
   6|                              
   5|                              
   4|                              
   3|                              
   2|   B       C                  
   1|                              
    +------------------------------
     123456789012345678901234567890

SHIP INFO
The size of the ship: a=8, b=10, c=6
The perimeter of the ship: 24
The area of the ship: 24
The angles of the ship: A=53.13 B=90.00 C=36.87 
The median points:  (8,2) (8,5) (4,5)
The centroid of the ship:  (6.67, 4) 
The length of the bisector: 6.71
The area of the inscribed circle: 12.57
The area of circumscribed circle: 78.54
The type of the ship: Scalene (Right-angled)  

Shoot: (16,5) 

  12|                              
  11|                              
  10|                              
   9|                              
   8|   A                          
   7|                              
   6|                              
   5|               X              
   4|                              
   3|                              
   2|   B       C                  
   1|                              
    +------------------------------
     123456789012345678901234567890

Your ship survived! Total score is 24 
Enter your name: Elif Polat

HIGH SCORE TABLE

Name  	        	Score
Nazan Kaya		60
Ali Kurt		30
Elif Polat		24	
  12|           B                  
  11|                              
  10|                              
   9|                              
   8|                              
   7|                              
   6|                              
   5|                              
   4|       A       C              
   3|                              
   2|                              
   1|                              
    +------------------------------
     123456789012345678901234567890

SHIP INFO
The size of the ship: a=8.94, b=8, c=8.94 
The perimeter of the ship: 25.89
The area of the ship: 32
The angles of the ship: A=63.44 B=53.12 C=63.44
The median points:  (14,8) (12,4) (10,8)
The centroid of the ship:  (12, 6.67) 
The length of the bisector: 7.18
The area of the inscribed circle: 19.2
The area of circumscribed circle: 78.54
The type of the ship: Isosceles (Acute-angled) 

Shoot: (14,4) 

  12|           B                  
  11|                              
  10|                              
   9|                              
   8|                              
   7|                              
   6|                              
   5|                              
   4|       A     X C              
   3|                              
   2|                              
   1|                              
    +------------------------------
     123456789012345678901234567890

Your ship sank! Total score is 0  

HIGH SCORE TABLE

Name  	        	Score
Nazan Kaya		60
Ali Kurt		30
Sibel Arslan		10


