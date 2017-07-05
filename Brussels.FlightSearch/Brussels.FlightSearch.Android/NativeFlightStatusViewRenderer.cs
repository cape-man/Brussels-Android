using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Brussels.FlightSearch;
using Brussels.FlightSearch.Droid;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;
using Brussels.FlightSearch.Entity;

[assembly: ExportRenderer(typeof(FlightStatusView), typeof(NativeFlightStatusViewRenderer))]
namespace Brussels.FlightSearch.Droid
{
    public class NativeFlightStatusViewRenderer : ViewRenderer<FlightStatusView, NativeFlightStatusView>
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == "Flight" && flightStatusView != null)
            {
                Flight flight = ((FlightStatusView)sender).Flight;
                if (flight != null)
                {
                    flightStatusView.DepatureAirportCodeTextView.Text = flight.FlightSchedule.DepartureAirportCode;
                    flightStatusView.DepatureCityTextView.Text = flight.FlightSchedule.DepartureCityName;

                    flightStatusView.ScheduledDepatureTimeTextView.Text = flight.FlightSchedule.ScheduledDepatureDateTime.ToString("H:mm"); 

                    flightStatusView.ActualDepatureTimeTextView.Text = flight.FlightSchedule.ActualDepatureDateTime.ToString("H:mm");

                    flightStatusView.ScheduledArrivalTimeTextView.Text = flight.FlightSchedule.ScheduledArrivalDateTime.ToString("H:mm");

                    flightStatusView.ActualArrivalTimeTextView.Text = flight.FlightSchedule.ActualArrivalDateTime.ToString("H:mm");

                    flightStatusView.ArrivalAirportCodeTextView.Text = flight.FlightSchedule.ArrivalAirportCode;

                    flightStatusView.ArrivalCityTextView.Text = flight.FlightSchedule.ArrivalCityName;

                    flightStatusView.FlightTimeTextView.Text = flight.FlightSchedule.FlightTime.ToString("%h\\:mm");
                }

            }
        }

        NativeFlightStatusView flightStatusView;
        protected override void OnElementChanged(ElementChangedEventArgs<FlightStatusView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                flightStatusView = new NativeFlightStatusView(this.Context);

                SetNativeControl(flightStatusView);

            }
        }
    }
}