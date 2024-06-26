﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyNutritionist.Models
{
    public class Leaderboard
    {
        [Key]
        public int LID { get; set; }
        public String City { get; set; }
        public ICollection<PremiumUser> Users { get; set; }

        private static readonly Leaderboard INSTANCE = new Leaderboard();
        private Leaderboard() { }

        public static Leaderboard getInstance() { return INSTANCE; }
    }
}
