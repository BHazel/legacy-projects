PROGRAM bottles
IMPLICIT NONE

INTEGER :: num_bottles, green_bottles
CHARACTER(LEN=20) :: bottle_colour

WRITE(*,*) "*** 10 Green Bottles ***"
WRITE(*,*) "How many bottles are on the wall?"
READ(*,*) num_bottles
WRITE(*,*) "What colour are the bottles on the wall?"
READ(*,*) bottle_colour

DO green_bottles=num_bottles,1,-1
IF (green_bottles /= 1) THEN
	WRITE(*,*) green_bottles, bottle_colour, " bottles sitting on the wall,"
	WRITE(*,*) green_bottles, bottle_colour, " bottles sitting on the wall,"
	WRITE(*,*) "And if 1 ", bottle_colour, " bottle were to accidentally fall"
	WRITE(*,*) "There'll be ", green_bottles-1, bottle_colour, " bottles sitting on the wall"
	WRITE(*,*) ""
ELSE
	WRITE(*,*) green_bottles, bottle_colour, " bottle sitting on the wall,"
	WRITE(*,*) green_bottles, bottle_colour, " bottle sitting on the wall,"
	WRITE(*,*) "And if that ", bottle_colour, " bottle were to accidentally fall"
	WRITE(*,*) "There'll be no ", bottle_colour, " bottles sitting on the wall"
	WRITE(*,*) ""
END IF
END DO

END PROGRAM bottles
