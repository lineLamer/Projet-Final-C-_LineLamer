﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Projet
{
    public class Projet : INotifyPropertyChanged
    {
        private int _idProjet;
        private string _nom;
        private string _description;
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private string _cheminImage;
        private ObservableCollection<Tache.Tache> _taches;

        public int IdProjet
        {
            get { return _idProjet; }
            set { _idProjet = value; OnPropertyChanged(); }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; OnPropertyChanged(); }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged(); }
        }

        public DateTime DateDebut
        {
            get { return _dateDebut; }
            set { _dateDebut = value; OnPropertyChanged(); }
        }

        public DateTime DateFin
        {
            get { return _dateFin; }
            set { _dateFin = value; OnPropertyChanged(); }
        }

        public string CheminImage
        {
            get { return _cheminImage; }
            set { _cheminImage = value; OnPropertyChanged(); }
        }

        public ObservableCollection<Tache.Tache> Taches
        {
            get { return _taches; }
            set { _taches = value; OnPropertyChanged(); }
        }

        public Projet(int idProjet, string nom, string description, DateTime dateDebut, DateTime dateFin, string cheminImage)
        {
            _idProjet = idProjet;
            _nom = nom;
            _description = description;
            _dateDebut = dateDebut;
            _dateFin = dateFin;
            _cheminImage = cheminImage;
            _taches = new ObservableCollection<Tache.Tache>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
