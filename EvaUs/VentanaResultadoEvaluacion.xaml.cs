using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.Timers;
using System.Windows.Threading;

namespace EvaUs
{
    /// <summary>
    /// Lógica de interacción para VentanaResultadoEvaluacion.xaml
    /// </summary>
    public partial class VentanaResultadoEvaluacion : MetroWindow
    {

        private double pje_us;
        private double actual_us;
        private double pje_co;
        private double actual_co;
        private double pje_ap;
        private double actual_ap;
        private double pje_op;
        private double actual_op;
        private double pje_at;
        private double actual_at;
        private double pje_cu;
        private double actual_cu;

        public VentanaResultadoEvaluacion()
        {
            InitializeComponent();
            softwareEvaluado("Página Phoenix Universidad de la Serena");
            pjeUsabilidad(21.5);
            pjeComprensibilidad(32);
            pjeAprendizaje(12);
            pjeOperabilidad(30);
            pjeAtractivo(15);
            pjeCumplimiento(10);
        }


        private void softwareEvaluado(string nombre)
        {
            nombre_software.Text = nombre;
        }

        private void evaluacionFinal( float usabilidad, float comprensibilidad, float aprendizaje,
            float operabilidad, float atractivo, float cumplimiento )
        {

        }

        private void pjeUsabilidad( Double porcentaje )
        {
            pje_us = porcentaje;
            actual_us = 0.0;
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(timerUsabilidad);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            dispatcherTimer.Start();
        }

        private void timerUsabilidad(object sender, EventArgs e)
        {
            // Updating the Label which displays the current second
            if( actual_us <= pje_us )
            {
                usabilidad.Content = actual_us + "%";
                actual_us += 1.0;
            }
            
            // Forcing the CommandManager to raise the RequerySuggested event
            CommandManager.InvalidateRequerySuggested();
        }

        private void pjeComprensibilidad(Double porcentaje)
        {
            pje_co = porcentaje;
            actual_co = 0.0;
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(timerComprensibilidad);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            dispatcherTimer.Start();
        }

        private void timerComprensibilidad(object sender, EventArgs e)
        {
            // Updating the Label which displays the current second
            if (actual_co <= pje_co)
            {
                comprensibilidad.Content = actual_co + "%";
                actual_co += 1.0;
            }

            // Forcing the CommandManager to raise the RequerySuggested event
            CommandManager.InvalidateRequerySuggested();
        }

        private void pjeAprendizaje(Double porcentaje)
        {
            pje_ap = porcentaje;
            actual_ap = 0.0;
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(timerAprendizaje);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            dispatcherTimer.Start();
        }

        private void timerAprendizaje(object sender, EventArgs e)
        {
            // Updating the Label which displays the current second
            if (actual_ap <= pje_ap)
            {
                aprendizaje.Content = actual_ap + "%";
                actual_ap += 1.0;
            }

            // Forcing the CommandManager to raise the RequerySuggested event
            CommandManager.InvalidateRequerySuggested();
        }

        private void pjeOperabilidad(Double porcentaje)
        {
            pje_op = porcentaje;
            actual_op = 0.0;
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(timerOperabilidad);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            dispatcherTimer.Start();
        }

        private void timerOperabilidad(object sender, EventArgs e)
        {
            // Updating the Label which displays the current second
            if (actual_op <= pje_op)
            {
                operabilidad.Content = actual_op + "%";
                actual_op += 1.0;
            }

            // Forcing the CommandManager to raise the RequerySuggested event
            CommandManager.InvalidateRequerySuggested();
        }

        private void pjeAtractivo(Double porcentaje)
        {
            pje_at = porcentaje;
            actual_at = 0.0;
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(timerAtractivo);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            dispatcherTimer.Start();
        }

        private void timerAtractivo(object sender, EventArgs e)
        {
            // Updating the Label which displays the current second
            if (actual_at <= pje_at)
            {
                atractivo.Content = actual_at + "%";
                actual_at += 1.0;
            }

            // Forcing the CommandManager to raise the RequerySuggested event
            CommandManager.InvalidateRequerySuggested();
        }

        private void pjeCumplimiento(Double porcentaje)
        {
            pje_cu = porcentaje;
            actual_cu = 0.0;
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(timerCumplimiento);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            dispatcherTimer.Start();
        }

        private void timerCumplimiento(object sender, EventArgs e)
        {
            // Updating the Label which displays the current second
            if (actual_cu <= pje_cu)
            {
                cumplimiento.Content = actual_cu + "%";
                actual_cu += 1.0;
            }

            // Forcing the CommandManager to raise the RequerySuggested event
            CommandManager.InvalidateRequerySuggested();
        }

    }
}
