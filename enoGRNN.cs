// Created by Abdulselam ARI
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace enosoft.NeuralNetworks
{
	class Program
	{
		static void Main(string[] args)
		{
			enoGRNN e = new enoGRNN();
            e.Calculate();
		}
	}
	
/*

Coded by Abdulselam ARI (c) 2018

Basic Neural Network : Algorithm and Example
1. What does GRNN do ??

This is basically a neural network based function approximation or function estimation algorithm. It predicts the output of a given input data.

2. How does it work ??

As per the basic principle of neural network it needs a training data to train itself. Training data should contain input-output mapping. Now if we train the network with the training data set and  we feed a new testing data set, it will accordingly gives the output or predict the result.
In case of GRNN, output is estimated  using weighted average of the outputs of training dataset, where the weight  is calculated using the euclidean distance between the training data  and   test data. If the weight or distance is large then the weight will be very less and if the distance is small it will put more weight to the output.
*/	
	    public  class enoGRNN
    {
        //What will be the output of 5??
        public double target = 5;
        public double sigma = 0.1;
        
        //input list
        public List<double> input1 = new List<double>() { 2,4,6,8};
        //output list
        public List<double> output1 = new List<double>() { 3,5,7,9};

        public double denominator = 0;
        public double numerator = 0;



        public void Calculate()
        {
            for (int i = 0; i < input1.Count; i++)
            {
                //Step 1 Calculate distances
                double d = Math.Pow((target - input1[i]), 2);

                //Step 2 Calculate weights using the activation function:
                double w = Math.Pow(2.71, (-d / (2 * Math.Pow(sigma, 2))));

                //Step 3 Summation of  w's for denominator
                denominator += w;
                numerator += w * output1[i];
            }


            //Step 4 So the output is: (Neumerator/Denominator ) So predicted is ->
            Console.WriteLine("predicted output is : " + (numerator / denominator));

        }


    }

	
}
