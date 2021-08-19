using System;
namespace BL
{
    public enum FbmiInterpretation{
        Underweight, NormalWeight,OverWeight,Obese
    }
    public class HealthStatus
    {
        // private static HealthStatus instance=null;
        // private HealthStatus()
        // {
            
        // }
        // public HealthStatus getInstance {
        //     get{
        //         if(instance==null)
        //             return new HealthStatus();
        //         return instance;
        //     }
        //  }
       /// <summary>
        /// This method estimates your cat's body's fat content based on its proportions. FBMI = (((rib cage/0.7062) - leg length )/0.9156) - leg length.
        /// </summary>
        /// <param name="ribCage">Measure of your cat's rib cage. Ideally, you want to do this at the 9th rib level, located by the cat's front legs.</param>
        /// <param name="length">Measure of the length of your cat's lower back leg from the knee to the ankle.</param>
        /// <returns> Feline Body Mass Index</returns>        
    public static double Fbmi(double ribCage, double legLength){
            if(ribCage>0 && legLength>0){
                System.Console.WriteLine($"Rib cage size - {ribCage} inches , Leg Length - {legLength} inches");
                var fbmi=(((ribCage/0.7062)-legLength)/0.9156)-legLength;
                System.Console.WriteLine($"FBMI - {fbmi}");
            return fbmi;
            }
            else
                throw new ArgumentException("ribcage and leg length must be greater than 0");
        } 
    public static FbmiInterpretation CatHealth(double fbmi){
            FbmiInterpretation interpretation=FbmiInterpretation.Underweight;
            if(fbmi<15)
                interpretation=FbmiInterpretation.Underweight;
            else if(fbmi>=15 && fbmi <30)
                 interpretation=FbmiInterpretation.NormalWeight;
            else if(fbmi>=30 && fbmi <=42)
                 interpretation=FbmiInterpretation.OverWeight;
            else if(fbmi>42 )
                 interpretation=FbmiInterpretation.Obese;
            return interpretation;
        }
    }
}