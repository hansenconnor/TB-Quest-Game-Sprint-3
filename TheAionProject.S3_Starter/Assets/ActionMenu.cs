﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// static class to hold key/value pairs for menu options
    /// </summary>
    public static class ActionMenu
    {
        public enum CurrentMenu
        {
            MissionIntro,
            InitializeMission,
            MainMenu,
            AdminMenu
        }

        public static CurrentMenu currentMenu = CurrentMenu.MainMenu;

        public static Menu AdminMenu = new Menu()
        {
            MenuName = "AdminMenu",
            MenuTitle = "Admin Menu",
            MenuChoices = new Dictionary<char, TravelerAction>()
            {
                { '1', TravelerAction.ListSpaceTimeLocations },
                { '2', TravelerAction.ListGameObjects },
                { '0', TravelerAction.ReturnToMainMenu }
            }
        };

        public static Menu MissionIntro = new Menu()
        {
            MenuName = "MissionIntro",
            MenuTitle = "",
            MenuChoices = new Dictionary<char, TravelerAction>()
                    {
                        { ' ', TravelerAction.None }
                    }
        };

        public static Menu InitializeMission = new Menu()
        {
            MenuName = "InitializeMission",
            MenuTitle = "Initialize Mission",
            MenuChoices = new Dictionary<char, TravelerAction>()
                {
                    { '1', TravelerAction.Exit }
                }
        };

        public static Menu MainMenu = new Menu()
        {
            MenuName = "MainMenu",
            MenuTitle = "Main Menu",
            MenuChoices = new Dictionary<char, TravelerAction>()
                {
                    { '1', TravelerAction.TravelerInfo },
                    { '2', TravelerAction.LookAround },
                    { '3', TravelerAction.LookAt },
                    { '4', TravelerAction.Travel },
                    { '5', TravelerAction.TravelerLocationsVisited },
                    { '6', TravelerAction.ListSpaceTimeLocations },
                    { '7', TravelerAction.ListGameObjects },
                    { '0', TravelerAction.Exit }
                }
        };

        //public static Menu ManageTraveler = new Menu()
        //{
        //    MenuName = "ManageTraveler",
        //    MenuTitle = "Manage Traveler",
        //    MenuChoices = new Dictionary<char, TravelerAction>()
        //            {
        //                TravelerAction.MissionSetup,
        //                TravelerAction.TravelerInfo,
        //                TravelerAction.Exit
        //            }
        //};
    }
}
