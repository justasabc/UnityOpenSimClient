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

Unity 3d introduction.

#  Quick guide
## Install
There are a few different ways you can install UnityOpenSimClient:

* Use cmd: `cmd UnityOpenSimClient.exe`
* Download the zipfile from the [downloads](https://github.com/justasabc/UnityOpenSimClient/archives/master) page and install it. 
* Checkout the source: `git clone git://github.com/justasabc/UnityOpenSimClient.git` and install it yourself.
   

## Getting Started
* Install UnityOpenSimClient
* **Get an API key** - to use the Echo Nest API you need an Echo Nest API key.  
* **Set the API** key - you can do this one of two ways:
* set an environment variable named `ECHO_NEST_API_KEY` to your API key
* Include this snippet of code at the beginning of your python scripts:


```python
    from pyechonest import config
    config.ECHO_NEST_API_KEY="YOUR API KEY"
```

* Check out the [docs](http://echonest.github.com/pyechonest/) and examples below.

## Examples
*All examples assume you have already setup your api key!*

Find artists that are similar to 'Bikini Kill':

```python
from pyechonest import artist
bk = artist.Artist('bikini kill')
print "Artists similar to: %s:" % (bk.name,)
for similar_artist in bk.similar: print "\t%s" % (similar_artist.name,)
```
