﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace ChessTeamProject
{
    public class FigureMove
    {

        public static void PerformPawnMove(IPawn pawn, int newRow, int newCol)
        {
            Console.WriteLine("Performing pawn's move...");
        }

        public static void PerformKingMove()
        {
            Console.WriteLine("Performing kings's move...");
        }

        public static void PerformQueenMove()
        {
            Console.WriteLine("Performing queen's move...");
        }

        public static void PerformBishopMove()
        {
            Console.WriteLine("Performing bishop's move...");
        }

        public static void PerformKnightMove()
        {
            Console.WriteLine("Performing knight's move...");
        }

        public static void PerformRookMove()
        {
            Console.WriteLine("Performing rook's move...");
        }
    }
}
