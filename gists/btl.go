package main

import (
	"flag"
	"fmt"
)

const (
	bottlesBeforeFallLine = "%d %s %s sitting on the wall.\n"
	fallLine = "And if 1 %s %s were to accidentally fall,\n"
	bottlesAfterFallLine = "There'll be %d %s %s sitting on the wall.\n"
)

var (
	bottles int
	colour string
)

func main() {
	parseCommandLine()
	runSong()
}

func parseCommandLine() {
	flag.IntVar(&bottles, "bottles", 10, "Number of bottles on the wall")
	flag.StringVar(&colour, "colour", "green", "Colour of the bottles on the wall")
	flag.Parse()
}

func runSong() {
	bottlesRemaining := bottles
	for {
		fmt.Printf(bottlesBeforeFallLine, bottlesRemaining, colour, getBottles(bottlesRemaining))
		fmt.Printf(bottlesBeforeFallLine, bottlesRemaining, colour, getBottles(bottlesRemaining))
		fmt.Printf(fallLine, colour, getBottles(1))
		bottlesRemaining--
		fmt.Printf(bottlesAfterFallLine, bottlesRemaining, colour, getBottles(bottlesRemaining))

		if bottlesRemaining == 0 {
			break
		} else {
			fmt.Println()
		}
	}
}

func getBottles(bottles int) string {
	if bottles == 1 {
		return "bottle"
	} else {
		return "bottles"
	}
}