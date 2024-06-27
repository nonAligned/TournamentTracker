﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackUI
{
    public partial class CreateTournamentForm : Form
    {
        List<TeamModel> availabelTeams = GlobalConfig.Connection.GetTeam_All();
        public CreateTournamentForm()
        {
            InitializeComponent();

            InitializeLists();
        }

        private void InitializeLists()
        {
            selectTeamDropDown.DataSource = availabelTeams;
            selectTeamDropDown.DisplayMember = "TeamName";
        }
    }
}
