﻿using System;

namespace EventsDelegates
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //Step 5 - Associate the event with the handler

            var person = new Person();
            person.name = "Marc";

            var alarm = new AlarmClock();
            alarm.AlarmClockEvent += person.HandleAlarm;

            //Step 6 - Causing the event to occur
            alarm.Alarm();



        }

    }

    // Step 4 - Creating code that should occur when the event happens
    public class Person
    {
        public string name { get; set; }

        public void HandleAlarm(object sender, AlarmClockEventArgs e)
        {
            Console.WriteLine("Get out of bed it's {0}", e.time);
        }
    }


    // Step 3 - Declaring the code for the event
    public class AlarmClock
    {
        public event AlarmClockEventHandler AlarmClockEvent;

        public void Alarm()
        {
            Console.WriteLine("Alarm went off!");
            AlarmClockEventHandler alarm = AlarmClockEvent;

            if (alarm != null)
            {
                alarm(this, new AlarmClockEventArgs(DateTime.Now));
            }


        }
    }


    // Step 2 - Setting up the delegate for the event
    public delegate void AlarmClockEventHandler(object source, AlarmClockEventArgs e);


    // Step 1 - Creating a class to pass arguments for the event handlers 
    public class AlarmClockEventArgs : EventArgs
    {

        public DateTime time { get; set; }

        public AlarmClockEventArgs(DateTime time)
        {
            this.time = time;
        }
    }
}
