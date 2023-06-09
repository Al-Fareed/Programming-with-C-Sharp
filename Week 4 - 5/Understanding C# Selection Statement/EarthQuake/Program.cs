﻿/*
EarthQuake Intensity Decision
Mr. Ram is a very rich businessman and he  lost his family in the Gujarat Earthquake. He lost interest in his business after the tragic incident and he decided to serve the society. He started an NGO named after his only son Santosh to help the earth-quake victims. Santosh Helpline will provide a compensation to all earth quake survivors.
The compensation amount given to the survivors is not fixed and it depends on the intensity of the earthquake.
The expression Richter magnitude scale refers to a number of ways to assign a single number to quantify the energy contained in an earthquake.
Earthquake Magnitude Scale
Magnitude
Type
2.4 or less
Micro
2.5 to 5.4
Light
5.5 to 6.0
Moderate
6.1 to 6.9
Strong
7.0 to 7.9
Major
8.0 or greater
Great
Please help Ram to decide the intensity of the earthquake.
Input Format:
Input consists of a single floating point number which corresponds to the earthquake's Richter magnitude scale.
Output Format:
Output consists of the string “Micro” or “Light” or “Moderate” or “Strong” or “Major” or Great”
Refer sample input and output for further formatting specifications.
[All text in bold corresponds to input and the rest corresponds to output]
Sample Input and Output 1:
Richter Magnitude:
5.7
Moderate
Sample Input and Output 2:
Richter Magnitude:
5
Light
*/


using System;
// Optimized code
using System;

class Program {
    static void Main() {
        Console.WriteLine("Richter Magnitude:");
        float intensity = float.Parse(Console.ReadLine());
        
        string mag = intensity <= 2.4 ? "Micro"
                   : intensity < 5.5 ? "Light"
                   : intensity <= 6.0 ? "Moderate"
                   : intensity <= 6.9 ? "Strong"
                   : intensity <= 7.9 ? "Major"
                   : "Great";
        
        Console.WriteLine(mag);
    }
}

// Another method
/*class Program{
    static void Main(){
        Console.WriteLine("Richter Magnitude:");
        float intensity=float.Parse(Console.ReadLine());
        string mag;
        if(intensity<=2.4){
            mag="Micro";
        }
        else if(intensity>=2.5 && intensity<5.5){
            mag="Light";
        }
        else if(intensity>=5.5 && intensity<=6.0){
            mag="Moderate";
        }
        else if(intensity>=6.1 && intensity<=6.9){
            mag="Strong";
        }
        else if(intensity>=7.0  && intensity<=7.9){
            mag="Major";
        }
        else{
            mag="Great";
        }
        Console.WriteLine(mag);
        
    }
}*/