﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Membres;
using Projet;

namespace Tache
{
    public class Tache : INotifyPropertyChanged
    {
        private int _idTache;
        private string _titre;
        private DateTime _dateEcheance;
        private int _priorite;
        private Membre _membre;
        private Projet _projet;

        public int IdTache
        {
            get { return _idTache; }
            set { _idTache = value; OnPropertyChanged(); }
        }

        public string Titre
        {
            get { return _titre; }
            set { _titre = value; OnPropertyChanged(); }
        }

        public DateTime DateEcheance
        {
            get { return _dateEcheance; }
            set { _dateEcheance = value; OnPropertyChanged(); }
        }

        public int Priorite
        {
            get { return _priorite; }
            set { _priorite = value; OnPropertyChanged(); }
        }


        public Membre Membres 
        {
            get { return _membre; }
            set { return _membre = value; } 

        }
        public Projet Projets 
        {
            get { return _projet; }
            set { return _projet = value; }
        }

        public Tache() : this(1,"tache1", new DateTime(2024,1,1), 1, new Membre(), new Projet())
        {

        }
        public Tache(int idTache, string titre, DateTime dateEcheance, int priorite, Membre membre, Projet projet)
        {
            _idTache = idTache;
            _titre = titre;
            _dateEcheance = dateEcheance;
            _priorite = priorite;
            _membre = membre;
            _projet = projet;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
