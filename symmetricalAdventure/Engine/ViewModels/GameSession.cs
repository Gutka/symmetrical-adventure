using Engine.Models;
using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession : INotifyPropertyChanged
    {
        private Location _CurrentLocation;

        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation
        {
            get
            {
                return _CurrentLocation;
            }
            set
            {
                _CurrentLocation = value;
                OnPropertyChanged("CurrentLocation");
                OnPropertyChanged("HasLocationToNorth");
                OnPropertyChanged("HasLocationToEast");
                OnPropertyChanged("HasLocationToSouth");
                OnPropertyChanged("HasLocationToWest");
            }
        }
        public bool HasLocationToNorth
        {
            get
            {
                return CurrentWorld.AtLocation(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
            }
        }
        public bool HasLocationToEast
        {
            get
            {
                return CurrentWorld.AtLocation(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
            }
        }
        public bool HasLocationToSouth
        {
            get
            {
                return CurrentWorld.AtLocation(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }
        }
        public bool HasLocationToWest
        {
            get
            {
                return CurrentWorld.AtLocation(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
            }
        }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Vyfetlo";
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.AtLocation(0, 0);

        }

        public void MoveNorth()
        {
            CurrentLocation = CurrentWorld.AtLocation(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
        }
        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.AtLocation(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
        }
        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.AtLocation(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
        }
        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.AtLocation(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
