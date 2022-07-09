# neural_networks
Neural Networks

GRNN : Generalized Regression Neural Networks
--------------

Basic Neural Network : Algorithm and Example
1. What does GRNN do ??

This is basically a neural network based function approximation or function estimation algorithm. It predicts the output of a given input data.

2. How does it work ??

As per the basic principle of neural network it needs a training data to train itself. Training data should contain input-output mapping. Now if we train the network with the training data set and  we feed a new testing data set, it will accordingly gives the output or predict the result.
In case of GRNN, output is estimated  using weighted average of the outputs of training dataset, where the weight  is calculated using the euclidean distance between the training data  and   test data. If the weight or distance is large then the weight will be very less and if the distance is small it will put more weight to the output.
