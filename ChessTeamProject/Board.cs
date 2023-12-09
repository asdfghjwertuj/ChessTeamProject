﻿using System.Collections.Generic;

namespace ChessTeamProject
{
    public class Board
    {
        public List<IPawn> P { get; } = new List<IPawn>();
        public List<IKing> K { get; } = new List<IKing>();
        public List<IQueen> Q { get; } = new List<IQueen>();
        public List<IBishop> B { get; } = new List<IBishop>();
        public List<IKnight> Kn { get; } = new List<IKnight>();
        public List<IRook> R { get; } = new List<IRook>();
    }
}
