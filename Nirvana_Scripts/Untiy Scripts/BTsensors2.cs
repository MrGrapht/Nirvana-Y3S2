using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using TechTweaking.Bluetooth;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BTsensors2 : MonoBehaviour {

	private  BluetoothDevice device;
//	public Text statusText;
//	public Text logsOnScreen; 

	public Transform cubes1LR;
	public Transform cubes2LR;
	public Transform cubes3LR;
	public Transform cubes4LR;
	public Transform cubes5LR;
	public Transform cubes6LR;
	public Transform cubes7LR;
	public Transform cubes8LR;
	public Transform cubes9LR;
	public Transform cubes10LR;
	public Transform cubes11LR;
	public Transform cubes12LR;
	public Transform cubes13LR;
	public Transform cubes14LR;
	public Transform cubes15LR;
	public Transform cubes16LR;
	public Transform cubes17LR;
	public Transform cubes18LR;
	public Transform cubes19LR;
	public Transform cubes20LR;
	
	public Transform cubes1UD;
	public Transform cubes2UD;
	public Transform cubes3UD;
	public Transform cubes4UD;
	public Transform cubes5UD;
	public Transform cubes6UD;
	public Transform cubes7UD;
	public Transform cubes8UD;
	public Transform cubes9UD;
	public Transform cubes10UD;
	public Transform cubes11UD;
	public Transform cubes12UD;
	public Transform cubes13UD;
	public Transform cubes14UD;
	public Transform cubes15UD;
	public Transform cubes16UD;
	public Transform cubes17UD;
	public Transform cubes18UD;
	public Transform cubes19UD;
	public Transform cubes20UD;
	
	public Transform cubes1FB;
	public Transform cubes2FB;
	public Transform cubes3FB;
	public Transform cubes4FB;
	public Transform cubes5FB;
	public Transform cubes6FB;
	public Transform cubes7FB;
	public Transform cubes8FB;
	public Transform cubes9FB;
	public Transform cubes10FB;
	public Transform cubes11FB;
	public Transform cubes12FB;
	public Transform cubes13FB;
	public Transform cubes14FB;
	public Transform cubes15FB;
	public Transform cubes16FB;
	public Transform cubes17FB;
	public Transform cubes18FB;
	public Transform cubes19FB;
	public Transform cubes20FB;

	// Here I could do one cube speed, then asign a Random.value to it... then divide/minus/times 1.5 or 10 or 0.5...
	// Random value seems a bit crazy though...
	//I'll put in my own values... 120 speeds...
	public float CubeSpeed1 = 1.0f;
	public float CubeSpeed2 = 1.0f;
	public float CubeSpeed3 = 1.0f;
	public float CubeSpeed4 = 1.0f;
	public float CubeSpeed5 = 1.0f;
	public float CubeSpeed6 = 1.0f;
	public float CubeSpeed7 = 1.0f;
	public float CubeSpeed8 = 1.0f;
	public float CubeSpeed9 = 1.0f;
	public float CubeSpeed10 = 1.0f;
	public float CubeSpeed11 = 1.0f;
	public float CubeSpeed12 = 1.0f;
	public float CubeSpeed13 = 1.0f;
	public float CubeSpeed14 = 1.0f;
	public float CubeSpeed15 = 1.0f;
	public float CubeSpeed16 = 1.0f;
	public float CubeSpeed17 = 1.0f;
	public float CubeSpeed18 = 1.0f;
	public float CubeSpeed19 = 1.0f;
	public float CubeSpeed20 = 1.0f;
	public float CubeSpeed21 = 1.0f;
	public float CubeSpeed22 = 1.0f;
	public float CubeSpeed23 = 1.0f;
	public float CubeSpeed24 = 1.0f;
	public float CubeSpeed25 = 1.0f;
	public float CubeSpeed26 = 1.0f;
	public float CubeSpeed27 = 1.0f;
	public float CubeSpeed28 = 1.0f;
	public float CubeSpeed29 = 1.0f;
	public float CubeSpeed30 = 1.0f;
	public float CubeSpeed31 = 1.0f;
	public float CubeSpeed32 = 1.0f;
	public float CubeSpeed33 = 1.0f;
	public float CubeSpeed34 = 1.0f;
	public float CubeSpeed35 = 1.0f;
	public float CubeSpeed36 = 1.0f;
	public float CubeSpeed37 = 1.0f;
	public float CubeSpeed38 = 1.0f;
	public float CubeSpeed39 = 1.0f;
	public float CubeSpeed40 = 1.0f;
	public float CubeSpeed41 = 1.0f;
	public float CubeSpeed42 = 1.0f;
	public float CubeSpeed43 = 1.0f;
	public float CubeSpeed44 = 1.0f;
	public float CubeSpeed45 = 1.0f;
	public float CubeSpeed46 = 1.0f;
	public float CubeSpeed47 = 1.0f;
	public float CubeSpeed48 = 1.0f;
	public float CubeSpeed49 = 1.0f;
	public float CubeSpeed50 = 1.0f;
	public float CubeSpeed51 = 1.0f;
	public float CubeSpeed52 = 1.0f;
	public float CubeSpeed53 = 1.0f;
	public float CubeSpeed54 = 1.0f;
	public float CubeSpeed55 = 1.0f;
	public float CubeSpeed56 = 1.0f;
	public float CubeSpeed57 = 1.0f;
	public float CubeSpeed58 = 1.0f;
	public float CubeSpeed59 = 1.0f;
	public float CubeSpeed60 = 1.0f;
	public float CubeSpeed61 = 1.0f;
	public float CubeSpeed62 = 1.0f;
	public float CubeSpeed63 = 1.0f;
	public float CubeSpeed64 = 1.0f;
	public float CubeSpeed65 = 1.0f;
	public float CubeSpeed66 = 1.0f;
	public float CubeSpeed67 = 1.0f;
	public float CubeSpeed68 = 1.0f;
	public float CubeSpeed69 = 1.0f;
	public float CubeSpeed70 = 1.0f;
	public float CubeSpeed71 = 1.0f;
	public float CubeSpeed72 = 1.0f;
	public float CubeSpeed73 = 1.0f;
	public float CubeSpeed74 = 1.0f;
	public float CubeSpeed75 = 1.0f;
	public float CubeSpeed76 = 1.0f;
	public float CubeSpeed77 = 1.0f;
	public float CubeSpeed78 = 1.0f;
	public float CubeSpeed79 = 1.0f;
	public float CubeSpeed80 = 1.0f;
	public float CubeSpeed81 = 1.0f;
	public float CubeSpeed82 = 1.0f;
	public float CubeSpeed83 = 1.0f;
	public float CubeSpeed84 = 1.0f;
	public float CubeSpeed85 = 1.0f;
	public float CubeSpeed86 = 1.0f;
	public float CubeSpeed87 = 1.0f;
	public float CubeSpeed88 = 1.0f;
	public float CubeSpeed89 = 1.0f;
	public float CubeSpeed90 = 1.0f;
	public float CubeSpeed91 = 1.0f;
	public float CubeSpeed92 = 1.0f;
	public float CubeSpeed93 = 1.0f;
	public float CubeSpeed94 = 1.0f;
	public float CubeSpeed95 = 1.0f;
	public float CubeSpeed96 = 1.0f;
	public float CubeSpeed97 = 1.0f;
	public float CubeSpeed98 = 1.0f;
	public float CubeSpeed99 = 1.0f;
	public float CubeSpeed100 = 1.0f;
	public float CubeSpeed101 = 1.0f;
	public float CubeSpeed102 = 1.0f;
	public float CubeSpeed103 = 1.0f;
	public float CubeSpeed104 = 1.0f;
	public float CubeSpeed105 = 1.0f;
	public float CubeSpeed106 = 1.0f;
	public float CubeSpeed107 = 1.0f;
	public float CubeSpeed108 = 1.0f;
	public float CubeSpeed109 = 1.0f;
	public float CubeSpeed110 = 1.0f;
	public float CubeSpeed111 = 1.0f;
	public float CubeSpeed112 = 1.0f;
	public float CubeSpeed113 = 1.0f;
	public float CubeSpeed114 = 1.0f;
	public float CubeSpeed115 = 1.0f;
	public float CubeSpeed116 = 1.0f;
	public float CubeSpeed117 = 1.0f;
	public float CubeSpeed118 = 1.0f;
	public float CubeSpeed119 = 1.0f;
	public float CubeSpeed120 = 1.0f;

	public Transform cylindersRight1;
	public Transform cylindersRight2;
	public Transform cylindersRight3;
	public Transform cylindersRight4;
	public Transform cylindersRight5;
	
	public Transform cylindersLeft1;
	public Transform cylindersLeft2;
	public Transform cylindersLeft3;
	public Transform cylindersLeft4;
	public Transform cylindersLeft5;

	public Transform cylindersForward1;
	public Transform cylindersForward2;
	public Transform cylindersForward3;
	public Transform cylindersForward4;
	public Transform cylindersForward5;

	public Transform cylindersBackward1;
	public Transform cylindersBackward2;
	public Transform cylindersBackward3;
	public Transform cylindersBackward4;
	public Transform cylindersBackward5;

	public Transform cylindersUp1;
	public Transform cylindersUp2;
	public Transform cylindersUp3;
	public Transform cylindersUp4;
	public Transform cylindersUp5;

	public Transform cylindersDown1;
	public Transform cylindersDown2;
	public Transform cylindersDown3;
	public Transform cylindersDown4;
	public Transform cylindersDown5;

	public float RotationSpeed1 = 1.0f;
	public float RotationSpeed2 = 1.0f;
	public float RotationSpeed3 = 1.0f;
	public float RotationSpeed4 = 1.0f;
	public float RotationSpeed5 = 1.0f;
	public float RotationSpeed6 = 1.0f;
	public float RotationSpeed7 = 1.0f;
	public float RotationSpeed8 = 1.0f;
	public float RotationSpeed9 = 1.0f;
	public float RotationSpeed10 = 1.0f;
	public float RotationSpeed11 = 1.0f;
	public float RotationSpeed12 = 1.0f;
	public float RotationSpeed13 = 1.0f;
	public float RotationSpeed14 = 1.0f;
	public float RotationSpeed15 = 1.0f;
	public float RotationSpeed16 = 1.0f;
	public float RotationSpeed17 = 1.0f;
	public float RotationSpeed18 = 1.0f;
	public float RotationSpeed19 = 1.0f;
	public float RotationSpeed20 = 1.0f;
	public float RotationSpeed21 = 1.0f;
	public float RotationSpeed22 = 1.0f;
	public float RotationSpeed23 = 1.0f;
	public float RotationSpeed24 = 1.0f;
	public float RotationSpeed25 = 1.0f;
	public float RotationSpeed26 = 1.0f;
	public float RotationSpeed27 = 1.0f;
	public float RotationSpeed28 = 1.0f;
	public float RotationSpeed29 = 1.0f;
	public float RotationSpeed30 = 1.0f;

	public Transform SoundCubes1;
	public Transform SoundCubes2;
	public Transform SoundCubes3;
	public Transform SoundCubes4;
	public Transform SoundCubes5;
	public Transform SoundCubes6;
	public Transform SoundCubes7;
	public Transform SoundCubes8;
	public Transform SoundCubes9;
	public Transform SoundCubes10;
	public Transform SoundCubes11;
	public Transform SoundCubes12;
	public Transform SoundCubes13;
	public Transform SoundCubes14;
	public Transform SoundCubes15;
	public Transform SoundCubes16;
	public Transform SoundCubes17;
	public Transform SoundCubes18;
	public Transform SoundCubes19;
	public Transform SoundCubes20;
	public Transform SoundCubes21;
	public Transform SoundCubes22;
	public Transform SoundCubes23;
	public Transform SoundCubes24;
	public Transform SoundCubes25;
	public Transform SoundCubes26;
	public Transform SoundCubes27;
	public Transform SoundCubes28;
	public Transform SoundCubes29;
	public Transform SoundCubes30;
	public Transform SoundCubes31;
	public Transform SoundCubes32;
	public Transform SoundCubes33;
	public Transform SoundCubes34;
	public Transform SoundCubes35;
	public Transform SoundCubes36;

	public float SoundCubesSpeed;
	public float SoundCubesSpeed2;


	public Transform cubeGameCube;
	public float cubeGameCubeSpeed;
	public float cubeGameCubeSpeed2;
	
	public Transform mazeSphere;
	public float mazeSphereSpeed;


	void Awake ()
	{
		device = new BluetoothDevice ();

		if (BluetoothAdapter.isBluetoothEnabled ()) {
			connect ();
		} else {

			//BluetoothAdapter.enableBluetooth(); //you can by this force enabling Bluetooth without asking the user
//			statusText.text = "Status : Please enable your Bluetooth";

			BluetoothAdapter.OnBluetoothStateChanged += HandleOnBluetoothStateChanged;
			BluetoothAdapter.listenToBluetoothState (); // if you want to listen to the following two events  OnBluetoothOFF or OnBluetoothON

			BluetoothAdapter.askEnableBluetooth ();//Ask user to enable Bluetooth

		}
	}

	void Start ()
	{
//		BluetoothAdapter.OnDeviceOFF += HandleOnDeviceOff;//This would mean a failure in connection! the reason might be that your remote device is OFF

//		BluetoothAdapter.OnDeviceNotFound += HandleOnDeviceNotFound; //Because connecting using the 'Name' property is just searching, the Plugin might not find it!.
	}

	private void connect ()
	{


//		statusText.text = "Status : Trying To Connect";
		

		/* The Property device.MacAdress doesn't require pairing. 
		 * Also Mac Adress in this library is Case sensitive,  all chars must be capital letters
		 */
		device.MacAddress = "20:16:09:19:45:98";
		
		/* device.Name = "My_Device";
		* 
		* Trying to identefy a device by its name using the Property device.Name require the remote device to be paired
		* but you can try to alter the parameter 'allowDiscovery' of the Connect(int attempts, int time, bool allowDiscovery) method.
		* allowDiscovery will try to locate the unpaired device, but this is a heavy and undesirable feature, and connection will take a longer time
		*/
						
						
		/*
		 * 10 equals the char '\n' which is a "new Line" in Ascci representation, 
		 * so the read() method will retun a packet that was ended by the byte 10. simply read() will read lines.
		 * If you don't use the setEndByte() method, device.read() will return any available data (line or not), then you can order them as you want.
		 */
		device.setEndByte (255);


		/*
		 * The ManageConnection Coroutine will start when the device is ready for reading.
		 */
		device.ReadingCoroutine = ManageConnection;


//		statusText.text = "Status : trying to connect";
		
		device.connect ();

	}


	//############### Handlers/Recievers #####################
	void HandleOnBluetoothStateChanged (bool isBtEnabled) {
		if (isBtEnabled) {
			connect ();
			//We now don't need our recievers
			BluetoothAdapter.OnBluetoothStateChanged -= HandleOnBluetoothStateChanged;
			BluetoothAdapter.stopListenToBluetoothState ();
		}
	}

	//This would mean a failure in connection! the reason might be that your remote device is OFF
//	void HandleOnDeviceOff (BluetoothDevice dev) {
//		if (!string.IsNullOrEmpty (dev.Name)) {
//			statusText.text = "Status : can't connect to '" + dev.Name + "', device is OFF ";
//		} else if (!string.IsNullOrEmpty (dev.MacAddress)) {
//			statusText.text = "Status : can't connect to '" + dev.MacAddress + "', device is OFF ";
//		}
//	}

	//Because connecting using the 'Name' property is just searching, the Plugin might not find it!.
//	void HandleOnDeviceNotFound (BluetoothDevice dev) {
//		if (!string.IsNullOrEmpty (dev.Name)) {
//			statusText.text = "Status : Can't find a device with the name '" + dev.Name + "', device might be OFF or not paired yet ";
//		} 
//	}
	
	public void disconnect () {
		if (device != null)
			device.close ();
	}

	IEnumerator  ManageConnection (BluetoothDevice device) {
//		statusText.text = "Status : Connected & Can read";
		while (device.IsConnected && device.IsReading) {
			
			//polll all available packets
			BtPackets packets = device.readAllPackets();
			
			if (packets != null) {
				
				/*
				 * parse packets, packets are ordered by indecies (0,1,2,3 ... N),
				 * where Nth packet is the latest packet and 0th is the oldest/first arrived packet.
				 * 
				 * Since this while loop is looping one time per frame, we only need the Nth(the latest potentiometer/joystick position in this frame).
				 * 
				 */
				int N = packets.Count - 1; 
				//packets.Buffer contains all the needed packets plus a header of meta data (indecies and sizes) 
				//To get a packet we need the INDEX and SIZE of that packet.
				int indx = packets.get_packet_offset_index(N);
				int size = packets.get_packet_size(N);
					
				if(size == 3) {
					// packets.Buffer[indx] equals lowByte(x1) and packets.Buffer[indx+1] equals highByte(x2)
					int val1 =  (packets.Buffer[indx+1] << 8) | packets.Buffer[indx];
					//Shift back 3 bits, because there was << 3 in Arduino
					val1 = val1 >> 3;
					//int val2 =  (packets.Buffer[indx+3] << 8) | packets.Buffer[indx+2];
					//Shift back 3 bits, because there was << 3 in Arduino
					//val2 = val2 >> 3;
			//		int val2 = (packets.Buffer[indx+2]);
					
					//#########Converting val1, val2 into something similar to Input.GetAxis (Which is from -1 to 1)#########
					//since any val is from 0 to 1023
					float Axis1 = ((float)val1/1023f)*2f - 1f;
					//float Axis2 = ((float)val2/1023f)*2f - 1f;
					MoveCube(Axis1);

					int val2 = (packets.Buffer[indx+2]);
//					logsOnScreen.text =  "Motion Sensor Value: " + val2;
					int Motion1 = val2;
					RotateCyl(Motion1);	


//					int val3 = (packets.Buffer[indx+3]);
//					int Sound1 = val3;
//					SoundCubes(Sound1);
				}

			//		RotateCyl(Motion1);
					/*
					 * 
					 * Now Axis1 or Axis2  value will be in the range -1...1. Similar to Input.GetAxis
					 * Check out :
					 * 
					 * https://docs.unity3d.com/ScriptReference/Input.GetAxis.html
					 * 
					 * https://unity3d.com/learn/tutorials/topics/scripting/getaxis
					 */
					
			//	}

			//	int M = packets.Count - 3; 
			//	int indxM = packets.get_packet_offset_index(M);
			//	int sizeM = packets.get_packet_size(M);

			//	if(sizeM == 1) {
					// packets.Buffer[indx] equals lowByte(x1) and packets.Buffer[indx+1] equals highByte(x2)
			//		int val2 = (packets.Buffer[indxM+2]);
				
					//float Axis2 = ((float)val2/1023f)*2f - 1f;
			//		int Motion1 = val2;

			//		RotateCyl(Motion1);		
			//	}

			
					
					
			}
			
			yield return null;
		}

//		statusText.text = "Status : Done Reading";

	}

	private void MoveCube(float thermoSensor) {
		
		//amountToMove = speed * Time.deltaTime;
		if (thermoSensor > -0.1) {
			//transform.Translate(Vector3.left * amountToMove, Space.World);
			//cube.position(Vector3.left * amountToMove, Space.World);
			cubes1LR.transform.Translate(Vector3.left * CubeSpeed1 * Time.deltaTime, Space.Self);
			cubes2LR.transform.Translate(Vector3.left * CubeSpeed2 * Time.deltaTime, Space.Self);
			cubes3LR.transform.Translate(Vector3.left * CubeSpeed3 * Time.deltaTime, Space.Self);
			cubes4LR.transform.Translate(Vector3.left * CubeSpeed4 * Time.deltaTime, Space.Self);
			cubes5LR.transform.Translate(Vector3.left * CubeSpeed5 * Time.deltaTime, Space.Self);
			cubes6LR.transform.Translate(Vector3.left * CubeSpeed6 * Time.deltaTime, Space.Self);
			cubes7LR.transform.Translate(Vector3.left * CubeSpeed7 * Time.deltaTime, Space.Self);
			cubes8LR.transform.Translate(Vector3.left * CubeSpeed8 * Time.deltaTime, Space.Self);
			cubes9LR.transform.Translate(Vector3.left * CubeSpeed9 * Time.deltaTime, Space.Self);
			cubes10LR.transform.Translate(Vector3.left * CubeSpeed10 * Time.deltaTime, Space.Self);
			cubes11LR.transform.Translate(Vector3.left * CubeSpeed11 * Time.deltaTime, Space.Self);
			cubes12LR.transform.Translate(Vector3.left * CubeSpeed12 * Time.deltaTime, Space.Self);
			cubes13LR.transform.Translate(Vector3.left * CubeSpeed13 * Time.deltaTime, Space.Self);
			cubes14LR.transform.Translate(Vector3.left * CubeSpeed14 * Time.deltaTime, Space.Self);
			cubes15LR.transform.Translate(Vector3.left * CubeSpeed15 * Time.deltaTime, Space.Self);
			cubes16LR.transform.Translate(Vector3.left * CubeSpeed16 * Time.deltaTime, Space.Self);
			cubes17LR.transform.Translate(Vector3.left * CubeSpeed17 * Time.deltaTime, Space.Self);
			cubes18LR.transform.Translate(Vector3.left * CubeSpeed18 * Time.deltaTime, Space.Self);
			cubes19LR.transform.Translate(Vector3.left * CubeSpeed19 * Time.deltaTime, Space.Self);
			cubes20LR.transform.Translate(Vector3.left * CubeSpeed20 * Time.deltaTime, Space.Self);

			cubes1UD.transform.Translate(Vector3.up * CubeSpeed21 * Time.deltaTime, Space.Self);
			cubes2UD.transform.Translate(Vector3.up * CubeSpeed22 * Time.deltaTime, Space.Self);
			cubes3UD.transform.Translate(Vector3.up * CubeSpeed23 * Time.deltaTime, Space.Self);
			cubes4UD.transform.Translate(Vector3.up * CubeSpeed24 * Time.deltaTime, Space.Self);
			cubes5UD.transform.Translate(Vector3.up * CubeSpeed25 * Time.deltaTime, Space.Self);
			cubes6UD.transform.Translate(Vector3.up * CubeSpeed26 * Time.deltaTime, Space.Self);
			cubes7UD.transform.Translate(Vector3.up * CubeSpeed27 * Time.deltaTime, Space.Self);
			cubes8UD.transform.Translate(Vector3.up * CubeSpeed28 * Time.deltaTime, Space.Self);
			cubes9UD.transform.Translate(Vector3.up * CubeSpeed29 * Time.deltaTime, Space.Self);
			cubes10UD.transform.Translate(Vector3.up * CubeSpeed30 * Time.deltaTime, Space.Self);
			cubes11UD.transform.Translate(Vector3.up * CubeSpeed31 * Time.deltaTime, Space.Self);
			cubes12UD.transform.Translate(Vector3.up * CubeSpeed32 * Time.deltaTime, Space.Self);
			cubes13UD.transform.Translate(Vector3.up * CubeSpeed33 * Time.deltaTime, Space.Self);
			cubes14UD.transform.Translate(Vector3.up * CubeSpeed34 * Time.deltaTime, Space.Self);
			cubes15UD.transform.Translate(Vector3.up * CubeSpeed35 * Time.deltaTime, Space.Self);
			cubes16UD.transform.Translate(Vector3.up * CubeSpeed36 * Time.deltaTime, Space.Self);
			cubes17UD.transform.Translate(Vector3.up * CubeSpeed37 * Time.deltaTime, Space.Self);
			cubes18UD.transform.Translate(Vector3.up * CubeSpeed38 * Time.deltaTime, Space.Self);
			cubes19UD.transform.Translate(Vector3.up * CubeSpeed39 * Time.deltaTime, Space.Self);
			cubes20UD.transform.Translate(Vector3.up * CubeSpeed40 * Time.deltaTime, Space.Self);

			cubes1FB.transform.Translate(Vector3.forward * CubeSpeed41 * Time.deltaTime, Space.Self);
			cubes2FB.transform.Translate(Vector3.forward * CubeSpeed42 * Time.deltaTime, Space.Self);
			cubes3FB.transform.Translate(Vector3.forward * CubeSpeed43 * Time.deltaTime, Space.Self);
			cubes4FB.transform.Translate(Vector3.forward * CubeSpeed44 * Time.deltaTime, Space.Self);
			cubes5FB.transform.Translate(Vector3.forward * CubeSpeed45 * Time.deltaTime, Space.Self);
			cubes6FB.transform.Translate(Vector3.forward * CubeSpeed46 * Time.deltaTime, Space.Self);
			cubes7FB.transform.Translate(Vector3.forward * CubeSpeed47 * Time.deltaTime, Space.Self);
			cubes8FB.transform.Translate(Vector3.forward * CubeSpeed48 * Time.deltaTime, Space.Self);
			cubes9FB.transform.Translate(Vector3.forward * CubeSpeed49 * Time.deltaTime, Space.Self);
			cubes10FB.transform.Translate(Vector3.forward * CubeSpeed50 * Time.deltaTime, Space.Self);
			cubes11FB.transform.Translate(Vector3.forward * CubeSpeed51 * Time.deltaTime, Space.Self);
			cubes12FB.transform.Translate(Vector3.forward * CubeSpeed52 * Time.deltaTime, Space.Self);
			cubes13FB.transform.Translate(Vector3.forward * CubeSpeed53 * Time.deltaTime, Space.Self);
			cubes14FB.transform.Translate(Vector3.forward * CubeSpeed54 * Time.deltaTime, Space.Self);
			cubes15FB.transform.Translate(Vector3.forward * CubeSpeed55 * Time.deltaTime, Space.Self);
			cubes16FB.transform.Translate(Vector3.forward * CubeSpeed56 * Time.deltaTime, Space.Self);
			cubes17FB.transform.Translate(Vector3.forward * CubeSpeed57 * Time.deltaTime, Space.Self);
			cubes18FB.transform.Translate(Vector3.forward * CubeSpeed58 * Time.deltaTime, Space.Self);
			cubes19FB.transform.Translate(Vector3.forward * CubeSpeed59 * Time.deltaTime, Space.Self);
			cubes20FB.transform.Translate(Vector3.forward * CubeSpeed60 * Time.deltaTime, Space.Self);

			cubeGameCube.transform.Translate(Vector3.right * (cubeGameCubeSpeed * Time.deltaTime), Space.Self);

			mazeSphere.transform.Translate(Vector3.right * (mazeSphereSpeed * Time.deltaTime), Space.Self);
		}
		
		if (thermoSensor < -0.1) {
		
			cubes1LR.transform.Translate(Vector3.right * CubeSpeed61 * Time.deltaTime, Space.Self);
			cubes2LR.transform.Translate(Vector3.right * CubeSpeed62 * Time.deltaTime, Space.Self);
			cubes3LR.transform.Translate(Vector3.right * CubeSpeed63 * Time.deltaTime, Space.Self);
			cubes4LR.transform.Translate(Vector3.right * CubeSpeed64 * Time.deltaTime, Space.Self);
			cubes5LR.transform.Translate(Vector3.right * CubeSpeed65 * Time.deltaTime, Space.Self);
			cubes6LR.transform.Translate(Vector3.right * CubeSpeed66 * Time.deltaTime, Space.Self);
			cubes7LR.transform.Translate(Vector3.right * CubeSpeed67 * Time.deltaTime, Space.Self);
			cubes8LR.transform.Translate(Vector3.right * CubeSpeed68 * Time.deltaTime, Space.Self);
			cubes9LR.transform.Translate(Vector3.right * CubeSpeed69 * Time.deltaTime, Space.Self);
			cubes10LR.transform.Translate(Vector3.right * CubeSpeed70 * Time.deltaTime, Space.Self);
			cubes11LR.transform.Translate(Vector3.right * CubeSpeed71 * Time.deltaTime, Space.Self);
			cubes12LR.transform.Translate(Vector3.right * CubeSpeed72 * Time.deltaTime, Space.Self);
			cubes13LR.transform.Translate(Vector3.right * CubeSpeed73 * Time.deltaTime, Space.Self);
			cubes14LR.transform.Translate(Vector3.right * CubeSpeed74 * Time.deltaTime, Space.Self);
			cubes15LR.transform.Translate(Vector3.right * CubeSpeed75 * Time.deltaTime, Space.Self);
			cubes16LR.transform.Translate(Vector3.right * CubeSpeed76 * Time.deltaTime, Space.Self);
			cubes17LR.transform.Translate(Vector3.right * CubeSpeed77 * Time.deltaTime, Space.Self);
			cubes18LR.transform.Translate(Vector3.right * CubeSpeed78 * Time.deltaTime, Space.Self);
			cubes19LR.transform.Translate(Vector3.right * CubeSpeed79 * Time.deltaTime, Space.Self);
			cubes20LR.transform.Translate(Vector3.right * CubeSpeed80 * Time.deltaTime, Space.Self);

			cubes1UD.transform.Translate(Vector3.down * CubeSpeed81 * Time.deltaTime, Space.Self);
			cubes2UD.transform.Translate(Vector3.down * CubeSpeed82 * Time.deltaTime, Space.Self);
			cubes3UD.transform.Translate(Vector3.down * CubeSpeed83 * Time.deltaTime, Space.Self);
			cubes4UD.transform.Translate(Vector3.down * CubeSpeed84 * Time.deltaTime, Space.Self);
			cubes5UD.transform.Translate(Vector3.down * CubeSpeed85 * Time.deltaTime, Space.Self);
			cubes6UD.transform.Translate(Vector3.down * CubeSpeed86 * Time.deltaTime, Space.Self);
			cubes7UD.transform.Translate(Vector3.down * CubeSpeed87 * Time.deltaTime, Space.Self);
			cubes8UD.transform.Translate(Vector3.down * CubeSpeed88 * Time.deltaTime, Space.Self);
			cubes9UD.transform.Translate(Vector3.down * CubeSpeed89 * Time.deltaTime, Space.Self);
			cubes10UD.transform.Translate(Vector3.down * CubeSpeed90 * Time.deltaTime, Space.Self);
			cubes11UD.transform.Translate(Vector3.down * CubeSpeed91 * Time.deltaTime, Space.Self);
			cubes12UD.transform.Translate(Vector3.down * CubeSpeed92 * Time.deltaTime, Space.Self);
			cubes13UD.transform.Translate(Vector3.down * CubeSpeed93 * Time.deltaTime, Space.Self);
			cubes14UD.transform.Translate(Vector3.down * CubeSpeed94 * Time.deltaTime, Space.Self);
			cubes15UD.transform.Translate(Vector3.down * CubeSpeed95 * Time.deltaTime, Space.Self);
			cubes16UD.transform.Translate(Vector3.down * CubeSpeed96 * Time.deltaTime, Space.Self);
			cubes17UD.transform.Translate(Vector3.down * CubeSpeed97 * Time.deltaTime, Space.Self);
			cubes18UD.transform.Translate(Vector3.down * CubeSpeed98 * Time.deltaTime, Space.Self);
			cubes19UD.transform.Translate(Vector3.down * CubeSpeed99 * Time.deltaTime, Space.Self);
			cubes20UD.transform.Translate(Vector3.down * CubeSpeed100 * Time.deltaTime, Space.Self);
			
			cubes1FB.transform.Translate(Vector3.back * CubeSpeed101 * Time.deltaTime, Space.Self);
			cubes2FB.transform.Translate(Vector3.back * CubeSpeed102 * Time.deltaTime, Space.Self);
			cubes3FB.transform.Translate(Vector3.back * CubeSpeed103 * Time.deltaTime, Space.Self);
			cubes4FB.transform.Translate(Vector3.back * CubeSpeed104 * Time.deltaTime, Space.Self);
			cubes5FB.transform.Translate(Vector3.back * CubeSpeed105 * Time.deltaTime, Space.Self);
			cubes6FB.transform.Translate(Vector3.back * CubeSpeed106 * Time.deltaTime, Space.Self);
			cubes7FB.transform.Translate(Vector3.back * CubeSpeed107 * Time.deltaTime, Space.Self);
			cubes8FB.transform.Translate(Vector3.back * CubeSpeed108 * Time.deltaTime, Space.Self);
			cubes9FB.transform.Translate(Vector3.back * CubeSpeed109 * Time.deltaTime, Space.Self);
			cubes10FB.transform.Translate(Vector3.back * CubeSpeed110 * Time.deltaTime, Space.Self);
			cubes11FB.transform.Translate(Vector3.back * CubeSpeed111 * Time.deltaTime, Space.Self);
			cubes12FB.transform.Translate(Vector3.back * CubeSpeed112 * Time.deltaTime, Space.Self);
			cubes13FB.transform.Translate(Vector3.back * CubeSpeed113 * Time.deltaTime, Space.Self);
			cubes14FB.transform.Translate(Vector3.back * CubeSpeed114 * Time.deltaTime, Space.Self);
			cubes15FB.transform.Translate(Vector3.back * CubeSpeed115 * Time.deltaTime, Space.Self);
			cubes16FB.transform.Translate(Vector3.back * CubeSpeed116 * Time.deltaTime, Space.Self);
			cubes17FB.transform.Translate(Vector3.back * CubeSpeed117 * Time.deltaTime, Space.Self);
			cubes18FB.transform.Translate(Vector3.back * CubeSpeed118 * Time.deltaTime, Space.Self);
			cubes19FB.transform.Translate(Vector3.back * CubeSpeed119 * Time.deltaTime, Space.Self);
			cubes20FB.transform.Translate(Vector3.back * CubeSpeed120 * Time.deltaTime, Space.Self);
			
			cubeGameCube.transform.Translate(Vector3.left * (cubeGameCubeSpeed * Time.deltaTime), Space.Self);

			mazeSphere.transform.Translate(Vector3.left * (mazeSphereSpeed * Time.deltaTime), Space.Self);
		}
	}

	private void RotateCyl(float motionSensor) {

		if (motionSensor == 1) {

			cylindersRight1.transform.Rotate ( Vector3.right * ( RotationSpeed1 * Time.deltaTime ) );
			cylindersRight2.transform.Rotate ( Vector3.right * ( RotationSpeed2 * Time.deltaTime ) );
			cylindersRight3.transform.Rotate ( Vector3.right * ( RotationSpeed3 * Time.deltaTime ) );
			cylindersRight4.transform.Rotate ( Vector3.right * ( RotationSpeed4 * Time.deltaTime ) );
			cylindersRight5.transform.Rotate ( Vector3.right * ( RotationSpeed5 * Time.deltaTime ) );

			cylindersLeft1.transform.Rotate ( Vector3.left * ( RotationSpeed6 * Time.deltaTime ) );
			cylindersLeft2.transform.Rotate ( Vector3.left * ( RotationSpeed7 * Time.deltaTime ) );
			cylindersLeft3.transform.Rotate ( Vector3.left * ( RotationSpeed8 * Time.deltaTime ) );
			cylindersLeft4.transform.Rotate ( Vector3.left * ( RotationSpeed9 * Time.deltaTime ) );
			cylindersLeft5.transform.Rotate ( Vector3.left * ( RotationSpeed10 * Time.deltaTime ) );

			cylindersUp1.transform.Rotate ( Vector3.up * ( RotationSpeed11 * Time.deltaTime ) );
			cylindersUp2.transform.Rotate ( Vector3.up * ( RotationSpeed12 * Time.deltaTime ) );
			cylindersUp3.transform.Rotate ( Vector3.up * ( RotationSpeed13 * Time.deltaTime ) );
			cylindersUp4.transform.Rotate ( Vector3.up * ( RotationSpeed14 * Time.deltaTime ) );
			cylindersUp5.transform.Rotate ( Vector3.up * ( RotationSpeed15 * Time.deltaTime ) );

			cylindersDown1.transform.Rotate ( Vector3.down * ( RotationSpeed16 * Time.deltaTime ) );
			cylindersDown2.transform.Rotate ( Vector3.down * ( RotationSpeed17 * Time.deltaTime ) );
			cylindersDown3.transform.Rotate ( Vector3.down * ( RotationSpeed18 * Time.deltaTime ) );
			cylindersDown4.transform.Rotate ( Vector3.down * ( RotationSpeed19 * Time.deltaTime ) );
			cylindersDown5.transform.Rotate ( Vector3.down * ( RotationSpeed20 * Time.deltaTime ) );

			cylindersForward1.transform.Rotate ( Vector3.forward * ( RotationSpeed21 * Time.deltaTime ) );
			cylindersForward2.transform.Rotate ( Vector3.forward * ( RotationSpeed22 * Time.deltaTime ) );
			cylindersForward3.transform.Rotate ( Vector3.forward * ( RotationSpeed23 * Time.deltaTime ) );
			cylindersForward4.transform.Rotate ( Vector3.forward * ( RotationSpeed24 * Time.deltaTime ) );
			cylindersForward5.transform.Rotate ( Vector3.forward * ( RotationSpeed25 * Time.deltaTime ) );

			cylindersBackward1.transform.Rotate ( Vector3.back * ( RotationSpeed26 * Time.deltaTime ) );
			cylindersBackward2.transform.Rotate ( Vector3.back * ( RotationSpeed27 * Time.deltaTime ) );
			cylindersBackward3.transform.Rotate ( Vector3.back * ( RotationSpeed28 * Time.deltaTime ) );
			cylindersBackward4.transform.Rotate ( Vector3.back * ( RotationSpeed29 * Time.deltaTime ) );
			cylindersBackward5.transform.Rotate ( Vector3.back * ( RotationSpeed30 * Time.deltaTime ) );

			cubeGameCube.transform.Translate(Vector3.forward * (cubeGameCubeSpeed2 * Time.deltaTime), Space.Self);

			SoundCubes1.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime), Space.Self);
			SoundCubes2.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes3.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes4.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes5.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes6.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes7.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes8.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes9.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes10.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes11.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes12.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes13.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes14.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes15.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes16.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes17.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes18.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes19.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes20.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes21.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes22.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes23.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes24.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes25.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes26.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes27.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes28.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes29.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes30.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes31.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes32.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes33.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes34.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes35.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));
			SoundCubes36.transform.Translate(Vector3.up * (SoundCubesSpeed * Time.deltaTime));

			mazeSphere.transform.Translate(Vector3.forward * (mazeSphereSpeed * Time.deltaTime), Space.Self);
		}

		else {

			cubeGameCube.transform.Translate(Vector3.back * (cubeGameCubeSpeed2 * Time.deltaTime), Space.Self);
			SoundCubes1.transform.Translate(Vector3.down * (SoundCubesSpeed2 * Time.deltaTime), Space.Self);
			mazeSphere.transform.Translate(Vector3.back * (mazeSphereSpeed * Time.deltaTime), Space.Self);
		}
	}

//		public void SoundCubes(float Microphone) {
//			if (Microphone < 525) {

		
//			}
		//	if (Microphone > 526) {
		//	else {
		//		SoundCubes1.transform.Translate(Vector3.down * (SoundCubesSpeed2 * Time.deltaTime) );
		//		SoundCubes2.transform.Translate(Vector3.down * (SoundCubesSpeed2 * Time.deltaTime) );
		//	}
//		}
}