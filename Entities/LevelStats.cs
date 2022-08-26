﻿using System;
using System.Collections.Generic;
using LiteDB;
namespace FallGuysStats {
    public class RoundInfo : IComparable<RoundInfo> {
        public ObjectId ID { get; set; }
        public int Profile { get; set; }
        public string Name { get; set; }
        public int ShowID { get; set; }
        public int Round { get; set; }
        public int Position { get; set; }
        public int? Score { get; set; }
        public int Tier { get; set; }
        public bool Qualified { get; set; }
        public int Kudos { get; set; }
        public int Players { get; set; }
        public bool InParty { get; set; }
        public bool IsFinal { get; set; }
        public bool PrivateLobby { get; set; }
        public DateTime Start { get; set; } = DateTime.MinValue;
        public DateTime End { get; set; } = DateTime.MinValue;
        public DateTime? Finish { get; set; } = null;
        public bool Crown { get; set; }
        public DateTime StartLocal;
        public DateTime EndLocal;
        public DateTime? FinishLocal;
        public DateTime ShowStart = DateTime.MinValue;
        public DateTime ShowEnd = DateTime.MinValue;
        public int GameDuration;
        public string SceneName;
        public bool Playing;
        private bool setLocalTime;

        public void ToLocalTime() {
            if (setLocalTime) { return; }
            setLocalTime = true;

            StartLocal = Start.ToLocalTime();
            EndLocal = End.ToLocalTime();
            if (Finish.HasValue) {
                FinishLocal = Finish.Value.ToLocalTime();
            }
        }
        public void VerifyName() {
            if (string.IsNullOrEmpty(SceneName)) { return; }

            string roundName;
            if (LevelStats.SceneToRound.TryGetValue(SceneName, out roundName)) {
                Name = roundName;
            }
        }
        public string VerifiedName() {
            if (string.IsNullOrEmpty(SceneName)) { return Name; }

            string roundName;
            if (LevelStats.SceneToRound.TryGetValue(SceneName, out roundName)) {
                return roundName;
            }
            return Name;
        }
        public override string ToString() {
            return $"{Name}: Round={Round} Position={Position} Duration={End - Start} Kudos={Kudos}";
        }
        public override bool Equals(object obj) {
            return obj is RoundInfo info
                && info.End == this.End
                && info.Finish == this.Finish
                && info.InParty == this.InParty
                && info.Kudos == this.Kudos
                && info.Players == this.Players
                && info.Position == this.Position
                && info.Qualified == this.Qualified
                && info.Round == this.Round
                && info.Score == this.Score
                && info.ShowID == this.ShowID
                && info.Start == this.Start
                && info.Tier == this.Tier
                && info.Name == this.Name;
        }
        public override int GetHashCode() {
            return Name.GetHashCode() ^ ShowID ^ Round;
        }
        public int CompareTo(RoundInfo other) {
            int showCompare = ShowID.CompareTo(other.ShowID);
            return showCompare != 0 ? showCompare : Round.CompareTo(other.Round);
        }
    }
    public enum QualifyTier {
        None,
        Gold,
        Silver,
        Bronze
    }
    public class LevelStats {
        public static Dictionary<string, LevelStats> ALL = new Dictionary<string, LevelStats>(StringComparer.OrdinalIgnoreCase) {
            { "round_airtime",                    new LevelStats(Resources.Strings.round_airtime, LevelType.Hunt, false, 6) },
            { "round_biggestfan",                 new LevelStats(Resources.Strings.round_big_fans, LevelType.Race, false, 2) },
            { "round_hoops_revenge_symphony_launch_show", new LevelStats(Resources.Strings.round_bounce_party, LevelType.Hunt, false, 7) },
            { "round_king_of_the_hill",           new LevelStats(Resources.Strings.round_bubble_trouble, LevelType.Hunt, false, 5) },
            { "round_1v1_button_basher",          new LevelStats(Resources.Strings.round_button_bashers, LevelType.Hunt, false, 4) },
            { "round_door_dash",                  new LevelStats(Resources.Strings.round_door_dash, LevelType.Race, false, 1) },
            { "round_gauntlet_02",                new LevelStats(Resources.Strings.round_dizzy_heights, LevelType.Race, false, 1) },
            { "round_iceclimb",                   new LevelStats(Resources.Strings.round_freezy_peak, LevelType.Race, false, 3) },
            { "round_dodge_fall",                 new LevelStats(Resources.Strings.round_fruit_chute, LevelType.Race, false, 1) },
            { "round_see_saw_360",                new LevelStats(Resources.Strings.round_full_tilt, LevelType.Race, false, 6) },
            { "round_chompchomp",                 new LevelStats(Resources.Strings.round_gate_crash, LevelType.Race, false, 1) },
            { "round_gauntlet_01",                new LevelStats(Resources.Strings.round_hit_parade, LevelType.Race, false, 1) },
            { "round_hoops_blockade_solo",        new LevelStats(Resources.Strings.round_hoopsie_legends, LevelType.Hunt, false, 2) },
            { "round_gauntlet_04",                new LevelStats(Resources.Strings.round_knight_fever, LevelType.Race, false, 2) },
            { "round_follow-the-leader_s6_launch",new LevelStats(Resources.Strings.round_leading_light, LevelType.Hunt, false, 6) },
            { "round_drumtop",                    new LevelStats(Resources.Strings.round_lily_leapers, LevelType.Race, false, 5) },
            { "round_gauntlet_08",                new LevelStats(Resources.Strings.round_party_promenade, LevelType.Race, false, 6) },
            { "round_penguin_solos",              new LevelStats(Resources.Strings.round_pegwin_party, LevelType.Hunt, false, 5) },
            { "round_pipedup_s6_launch",          new LevelStats(Resources.Strings.round_pipe_dream, LevelType.Race, false, 6) },
            { "round_tunnel_race",                new LevelStats(Resources.Strings.round_roll_on, LevelType.Race, false, 4) },
            { "round_see_saw",                    new LevelStats(Resources.Strings.round_see_saw, LevelType.Race, false, 1) },
            { "round_shortcircuit",               new LevelStats(Resources.Strings.round_short_circuit, LevelType.Race, false, 4) },
            { "round_skeefall",                   new LevelStats(Resources.Strings.round_ski_fall, LevelType.Hunt, false, 3) },
            { "round_gauntlet_06",                new LevelStats(Resources.Strings.round_skyline_stumble, LevelType.Race, false, 4) },
            { "round_lava",                       new LevelStats(Resources.Strings.round_slime_climb, LevelType.Race, false, 1) },
            { "round_slimeclimb_2",               new LevelStats(Resources.Strings.round_slimescraper, LevelType.Race, false, 4) },
            { "round_short_circuit_2_symphony_launch_show", new LevelStats(Resources.Strings.round_speed_circuit, LevelType.Race, false, 7) },
            { "round_tip_toe",                    new LevelStats(Resources.Strings.round_tip_toe, LevelType.Race, false, 1) },
            { "round_gauntlet_09_symphony_launch_show", new LevelStats(Resources.Strings.round_track_attack, LevelType.Race, false, 7) },
            { "round_gauntlet_07",                new LevelStats(Resources.Strings.round_treetop_tumble, LevelType.Race, false, 5) },
            { "round_gauntlet_05",                new LevelStats(Resources.Strings.round_tundra_run, LevelType.Race, false, 3) },
            { "round_gauntlet_03",                new LevelStats(Resources.Strings.round_whirlygig, LevelType.Race, false, 1) },
            { "round_wall_guys",                  new LevelStats(Resources.Strings.round_wall_guys, LevelType.Race, false, 2) },

            { "round_fruitpunch_s4_show",         new LevelStats(Resources.Strings.round_big_shots, LevelType.Survival, false, 4) },
            { "round_block_party",                new LevelStats(Resources.Strings.round_block_party, LevelType.Survival, false, 1) },
            { "round_hoverboardsurvival_s4_show", new LevelStats(Resources.Strings.round_hoverboard_heroes, LevelType.Survival, false, 4) },
            { "round_jump_club",                  new LevelStats(Resources.Strings.round_jump_club, LevelType.Survival, false, 1) },
            { "round_match_fall",                 new LevelStats(Resources.Strings.round_perfect_match, LevelType.Survival, false, 1) },
            { "round_tunnel",                     new LevelStats(Resources.Strings.round_roll_out, LevelType.Survival, false, 1) },
            { "round_snowballsurvival",           new LevelStats(Resources.Strings.round_snowball_survival, LevelType.Survival, false, 3) },
            { "round_robotrampage_arena_2",       new LevelStats(Resources.Strings.round_stompin_ground, LevelType.Survival, false, 5) },
            { "round_fruit_bowl",                 new LevelStats(Resources.Strings.round_sum_fruit, LevelType.Survival, false, 5) },
            { "round_tail_tag",                   new LevelStats(Resources.Strings.round_tail_tag, LevelType.Survival, false, 1) },
            { "round_spin_ring_symphony_launch_show", new LevelStats(Resources.Strings.round_the_swiveller, LevelType.Survival, false, 7) },
            { "round_1v1_volleyfall_symphony_launch_show", new LevelStats(Resources.Strings.round_volleyfall, LevelType.Survival, false, 7) },

            { "round_basketfall_s4_show",         new LevelStats(Resources.Strings.round_basketfall, LevelType.Team, false, 4) },
            { "round_egg_grab",                   new LevelStats(Resources.Strings.round_egg_scramble, LevelType.Team, false, 1) },
            { "round_egg_grab_02",                new LevelStats(Resources.Strings.round_egg_siege, LevelType.Team, false, 2) },
            { "round_fall_ball_60_players",       new LevelStats(Resources.Strings.round_fall_ball, LevelType.Team, false, 1) },
            { "round_ballhogs",                   new LevelStats(Resources.Strings.round_hoarders, LevelType.Team, false, 1) },
            { "round_hoops",                      new LevelStats(Resources.Strings.round_hoopsie_daisy, LevelType.Team, false, 1) },
            { "round_jinxed",                     new LevelStats(Resources.Strings.round_jinxed, LevelType.Team, false, 1) },
            { "round_chicken_chase",              new LevelStats(Resources.Strings.round_pegwin_pursuit, LevelType.Team, false, 3) },
            { "round_territory_control_s4_show",  new LevelStats(Resources.Strings.round_power_trip, LevelType.Team, false, 4) },
            { "round_rocknroll",                  new LevelStats(Resources.Strings.round_rock_n_roll, LevelType.Team, false, 1) },
            { "round_snowy_scrap",                new LevelStats(Resources.Strings.round_snowy_scrap, LevelType.Team, false, 3) },
            { "round_invisibeans",                new LevelStats(Resources.Strings.round_sweet_thieves, LevelType.Team, false, 6) },
            { "round_conveyor_arena",             new LevelStats(Resources.Strings.round_team_tail_tag, LevelType.Team, false, 1) },

            { "round_blastball_arenasurvival_symphony_launch_show", new LevelStats(Resources.Strings.round_blast_ball, LevelType.Survival, true, 7) },
            { "round_fall_mountain_hub_complete", new LevelStats(Resources.Strings.round_fall_mountain, LevelType.Race, true, 1) },
            { "round_floor_fall",                 new LevelStats(Resources.Strings.round_hex_a_gone, LevelType.Survival, true, 1) },
            { "round_hexaring_symphony_launch_show", new LevelStats(Resources.Strings.round_hex_a_ring, LevelType.Survival, true, 7) },
            { "round_jump_showdown",              new LevelStats(Resources.Strings.round_jump_showdown, LevelType.Survival, true, 1) },
            { "round_crown_maze",                 new LevelStats(Resources.Strings.round_lost_temple, LevelType.Race, true, 5) },
            { "round_tunnel_final",               new LevelStats(Resources.Strings.round_roll_off, LevelType.Survival, true, 3) },
            { "round_royal_rumble",               new LevelStats(Resources.Strings.round_royal_fumble, LevelType.Hunt, true, 1) },
            { "round_thin_ice",                   new LevelStats(Resources.Strings.round_thin_ice, LevelType.Survival, true, 3) }
        };
        public static Dictionary<string, string> SceneToRound = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {
            { "FallGuy_Airtime",                   "round_airtime" },
            { "FallGuy_BiggestFan",                "round_biggestfan" },
            { "FallGuy_HoopsRevenge",              "round_hoops_revenge_symphony_launch_show" },
            { "FallGuy_KingOfTheHill2",            "round_king_of_the_hill" },
            { "FallGuy_1v1_ButtonBasher",          "round_1v1_button_basher" },
            { "FallGuy_DoorDash",                  "round_door_dash" },
            { "FallGuy_Gauntlet_02_01",            "round_gauntlet_02" },
            { "FallGuy_IceClimb_01",               "round_iceclimb" },
            { "FallGuy_DodgeFall",                 "round_dodge_fall" },
            { "FallGuy_SeeSaw360",                 "round_see_saw_360" },
            { "FallGuy_ChompChomp_01",             "round_chompchomp" },
            { "FallGuy_Gauntlet_01",               "round_gauntlet_01" },
            { "FallGuy_Hoops_Blockade",            "round_hoops_blockade_solo" },
            { "FallGuy_Gauntlet_04",               "round_gauntlet_04" },
            { "FallGuy_FollowTheLeader",           "round_follow-the-leader_s6_launch" },
            { "FallGuy_DrumTop",                   "round_drumtop" },
            { "FallGuy_Gauntlet_08",               "round_gauntlet_08" },
            { "FallGuy_Penguin_Solos",             "round_penguin_solos" },
            { "FallGuy_PipedUp",                   "round_pipedup_s6_launch" },
            { "FallGuy_Tunnel_Race_01",            "round_tunnel_race" },
            { "FallGuy_SeeSaw_variant2",           "round_see_saw" },
            { "FallGuy_ShortCircuit",              "round_shortcircuit" },
            { "FallGuy_SkeeFall",                  "round_skeefall" },
            { "FallGuy_Gauntlet_06",               "round_gauntlet_06" },
            { "FallGuy_Lava_02",                   "round_lava" },
            { "FallGuy_SlimeClimb_2",              "round_slimeclimb_2" },
            { "FallGuy_ShortCircuit2",             "round_short_circuit_2_symphony_launch_show" },
            { "FallGuy_TipToe",                    "round_tip_toe" },
            { "FallGuy_Gauntlet_09",               "round_gauntlet_09_symphony_launch_show" },
            { "FallGuy_Gauntlet_07",               "round_gauntlet_07" },
            { "FallGuy_Gauntlet_05",               "round_gauntlet_05" },
            { "FallGuy_Gauntlet_03",               "round_gauntlet_03" },
            { "FallGuy_WallGuys",                  "round_wall_guys" },

            { "FallGuy_FruitPunch",                "round_fruitpunch_s4_show" },
            { "FallGuy_BlastBall_ArenaSurvival",   "round_blastball_arenasurvival_symphony_launch_show" },
            { "FallGuy_Block_Party",               "round_block_party" },
            { "FallGuy_HoverboardSurvival",        "round_hoverboardsurvival_s4_show" },
            { "FallGuy_JumpClub_01",               "round_jump_club" },
            { "FallGuy_MatchFall",                 "round_match_fall" },
            { "FallGuy_Tunnel_01",                 "round_tunnel" },
            { "FallGuy_SnowballSurvival",          "round_snowballsurvival" },
            { "FallGuy_RobotRampage_Arena2",       "round_robotrampage_arena_2" },
            { "FallGuy_FruitBowl",                 "round_fruit_bowl" },
            { "FallGuy_TailTag_2",                 "round_tail_tag" },
            { "FallGuy_SpinRing",                  "round_spin_ring_symphony_launch_show" },
            { "FallGuy_1v1_Volleyfall",            "round_1v1_volleyfall_symphony_launch_show" },

            { "FallGuy_Basketfall_01",             "round_basketfall_s4_show" },
            { "FallGuy_EggGrab",                   "round_egg_grab" },
            { "FallGuy_EggGrab_02",                "round_egg_grab_02" },
            { "FallGuy_FallBall_5",                "round_fall_ball_60_players" },
            { "FallGuy_BallHogs_01",               "round_ballhogs" },
            { "FallGuy_Hoops_01",                  "round_hoops" },
            { "FallGuy_TeamInfected",              "round_jinxed" },
            { "FallGuy_ChickenChase_01",           "round_chicken_chase" },
            { "FallGuy_TerritoryControl_v2",       "round_territory_control_s4_show" },
            { "FallGuy_RocknRoll",                 "round_rocknroll" },
            { "FallGuy_Snowy_Scrap",               "round_snowy_scrap" },
            { "FallGuy_Invisibeans",               "round_invisibeans" },
            { "FallGuy_ConveyorArena_01",          "round_conveyor_arena" },

            { "FallGuy_FallMountain_Hub_Complete", "round_fall_mountain_hub_complete" },
            { "FallGuy_FloorFall",                 "round_floor_fall" },
            { "FallGuy_HexARing",                  "round_hexaring_symphony_launch_show" },
            { "FallGuy_JumpShowdown_01",           "round_jump_showdown" },
            { "FallGuy_Crown_Maze_Topdown",        "round_crown_maze" },
            { "FallGuy_Tunnel_Final",              "round_tunnel_final" },
            { "FallGuy_Arena_01",                  "round_royal_rumble" },
            { "FallGuy_ThinIce",                   "round_thin_ice" }
        };

        public string Name { get; set; }
        public int Qualified { get; set; }
        public int Gold { get; set; }
        public int Silver { get; set; }
        public int Bronze { get; set; }
        public int Played { get; set; }
        public int Kudos { get; set; }
        public TimeSpan Fastest { get; set; }
        public TimeSpan Longest { get; set; }
        public int AveKudos { get { return Kudos / (Played == 0 ? 1 : Played); } }
        public LevelType Type;
        public bool IsFinal;
        public TimeSpan AveDuration { get { return TimeSpan.FromSeconds((int)Duration.TotalSeconds / (Played == 0 ? 1 : Played)); } }
        public TimeSpan AveFinish { get { return TimeSpan.FromSeconds((double)FinishTime.TotalSeconds / (FinishedCount == 0 ? 1 : FinishedCount)); } }
        public TimeSpan Duration;
        public TimeSpan FinishTime;
        public List<RoundInfo> Stats;
        public int Season;
        public int FinishedCount;

        public LevelStats(string levelName, LevelType type, bool isFinal, int season) {
            Name = levelName;
            Type = type;
            Season = season;
            IsFinal = isFinal;
            Stats = new List<RoundInfo>();
            Clear();
        }
        public void Clear() {
            Qualified = 0;
            Gold = 0;
            Silver = 0;
            Bronze = 0;
            Played = 0;
            Kudos = 0;
            FinishedCount = 0;
            Duration = TimeSpan.Zero;
            FinishTime = TimeSpan.Zero;
            Fastest = TimeSpan.Zero;
            Longest = TimeSpan.Zero;
            Stats.Clear();
        }
        public void Add(RoundInfo stat) {
            Stats.Add(stat);
            if (!stat.PrivateLobby) {
                Played++;

                switch (stat.Tier) {
                    case (int)QualifyTier.Gold:
                        Gold++;
                        break;
                    case (int)QualifyTier.Silver:
                        Silver++;
                        break;
                    case (int)QualifyTier.Bronze:
                        Bronze++;
                        break;
                }

                Kudos += stat.Kudos;
                Duration += stat.End - stat.Start;
                Qualified += stat.Qualified ? 1 : 0;
            }

            TimeSpan finishTime = stat.Finish.GetValueOrDefault(stat.End) - stat.Start;
            if (stat.Finish.HasValue && finishTime.TotalSeconds > 1.1) {
                if (!stat.PrivateLobby) {
                    FinishedCount++;
                    FinishTime += finishTime;
                }
                if (Fastest == TimeSpan.Zero || Fastest > finishTime) {
                    Fastest = finishTime;
                }
                if (Longest < finishTime) {
                    Longest = finishTime;
                }
            }
        }

        public override string ToString() {
            return $"{Name}: {Qualified} / {Played}";
        }
    }
}