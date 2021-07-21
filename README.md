This respository is experimented as the minimum project file in Mobile way for achieving the idea of Milgram and Kishino's Reality-Virtuality continuum (1994).  
Packages in the project:  
1. ARFoundation 4.1.7  
2. ARKit XR Plugin  4.1.7  
3. OSCJackVS (Regenerate Units in Project Settings - Visual Scripting)  
4. Unity's Starter Assets - Third Person Character Controller  
5. Post Processing 3.1.1  
6. Probuilder  
## 1.Text-based to Augmented Virtuality  
## 2.Augmented Virtuality to OSC control other screen  
Using Keijiro's OscJackVS respository as the screen's receiver (https://github.com/keijiro/OscJackVS)  
Setup steps:
1. Run OscJackVS and check the IP for the device  
2. Fill OSC Transmitter with the IP in the gameobject OSC Manager  
3. Select the IP in the component Float Informer in the gameobject Slider/1    
## 3.Augmented Virtuality to Augmented Reality  
## 4.Augmented Reality to OSC control other screen  
Using Keijiro's OscJackVS respository as the screen's receiver (https://github.com/keijiro/OscJackVS)  
Setup steps:
1. Run OscJackVS and check the IP for the device  
2. Fill OSC Transmitter with the IP in the OSC Manager of prefab PlacedBall  
3. Select the IP in the component Float Informer in the gameobject Slider/1 of prefav PlacedBall  
