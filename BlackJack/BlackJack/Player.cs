﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
   public class Player
    {

        public Player(string name, int begginingBalance)
        {
            Hand = new List<Card>();
            Balance = begginingBalance;
            Name = name;
        }
        public List<Card> Hand { get; set; }
        public int balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool stay { get; set; }

        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }


    }
}
