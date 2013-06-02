UnityOpenSimClient
==================
* Server: Opensimulator
* Client: Unity3D 
* Script Language: C#


# Server

[OpenSimulator](http://opensimulator.org/wiki/Main_Page) 

OpenSimulator is an open source multi-platform, multi-user 3D application server. It can be used to create a virtual environment (or world) which can be accessed through a variety of clients, on multiple protocols. It also has an optional facility (the Hypergrid) to allow users to visit other OpenSimulator installations across the web from an account on a 'home' OpenSimulator installation.

# Client

[Unity 3D](http://unity3d.com/)

Unity is a game development ecosystem: a powerful rendering engine fully integrated with a complete set of intuitive tools and rapid workflows to create interactive 3D content; easy multiplatform publishing; thousands of quality, ready-made assets in the Asset Store and a knowledge-sharing Community.

For independent developers and studios, Unity’s democratizing ecosystem smashes the time and cost barriers to creating uniquely beautiful games. They are using Unity to build a livelihood doing what they love: creating games that hook and delight players on any platform.

#  Quick guide

## Getting Started
Getting started with *UnityOpenSimClient* are as follows:
* **Checkout** the source: `git clone git://github.com/justasabc/UnityOpenSimClient.git`.
* **Stat** Opensimulator server.
* **Open** UnityOpenSimClient.unity with Unity3D.


```python
    from pyechonest import config
    config.ECHO_NEST_API_KEY="YOUR API KEY"
```

## Example code
GetClientName
```
// We can add convenience methods to do tedious tasks and use them
        private string GetClientName(OpenSim.Framework.IClientAPI client)
        {
            return String.Format("{0} {1}", client.FirstName, client.LastName);
        }
        
```
