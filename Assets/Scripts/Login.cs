using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using OpenMetaverse;
using OpenMetaverse.Rendering;

public class Login : MonoBehaviour {
	public GridClient Client = new GridClient();
	public Dictionary<uint, FacetedMesh> Prims = new Dictionary<uint, FacetedMesh>();
	//MeshmerizerR R = new MeshmerizerR();
	//System.Drawing.Bitmap t;
	//System.Net.IPEndPointCollection i;
	// Use this for initialization
	string userName = "Test User";
	string password = "1234";
	string server = "http://localhost:9000";
	
	void Start () { 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void StartLogin(string name, string pass, string server)
	{
		string LOGIN_SERVER = server;
        string FIRST_NAME = name.Split(' ')[0];
        string LAST_NAME = name.Split(' ')[1];
        string PASSWORD = pass;
        string CHANNEL = "KZLAGENT";
        string VERSION = "KZLVERSION";

        LoginParams loginParams = Client.Network.DefaultLoginParams(
            FIRST_NAME, LAST_NAME, PASSWORD, CHANNEL, VERSION);

        loginParams.URI = LOGIN_SERVER; // KZL

        // Set handler
        Client.Network.LoginProgress += Network_OnLoginProcess;
//            Client.Network.Disconnected += Network_OnDisconnected;
//            Client.Network.LoggedOut += Network_OnLoggedout;
//
        Client.Objects.ObjectUpdate += Objects_OnObjectUpdate;

        // Login to Simulator
        Client.Network.BeginLogin(loginParams);
		Debug.Log("Start Connecting");
	}
	
	void Network_OnLoginProcess(object sender, LoginProgressEventArgs e)
    {
        if (e.Status == LoginStatus.ConnectingToSim)
        { // first time
			Debug.Log("Connecting to OpenSim");
        }
        else if (e.Status == LoginStatus.Success)
        { // second time
            Debug.Log("Connecting Success!");
        }
        else if (e.Status == LoginStatus.Failed)
        {
            Debug.Log("Connecting Failed!");
        }
    }
	void LogOut()
	{
		if (Client.Network.Connected)
		{
			Client.Network.Logout();
			Debug.Log ("Logout success!");
		}
	}
	
    void Objects_OnObjectUpdate(object sender, PrimEventArgs e)
    {
		FacetedMesh mesh = null;
		FacetedMesh existingMesh = null;
		
		//FIXME : need to lock prims
		if (Prims.ContainsKey(e.Prim.LocalID))
			existingMesh = Prims[e.Prim.LocalID];
		
		if (e.Prim.Sculpt != null)
		{
			//leave sculpt prim out temporarily
		}
		//else
			//mesh = R.GenerateFacetedMesh(e.Prim, DetailLevel.Highest);
		
	}
	
	void OnGUI()
	{
		GUILayout.Label("用户名");
		userName = GUILayout.TextField(userName);
		GUILayout.Label("密码");
		password = GUILayout.TextField(password);
		GUILayout.Label("登录地址");
		server = GUILayout.TextField(server);
		if (GUILayout.Button("登录"))
			StartLogin(userName, password, server);
		if (GUILayout.Button("登出"))
			LogOut();
	}
}
