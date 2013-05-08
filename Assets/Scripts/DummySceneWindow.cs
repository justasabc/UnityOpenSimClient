using UnityEngine;
using System.Collections;
using OpenMetaverse;
using Radegast.Rendering;

public class SceneWindow
{
	public void StartShiny(){}
	public bool TryGetTextureInfo(UUID textureID, out TextureInfo info){
		info = new TextureInfo();
		return false;}
	public void DownloadTexture(TextureLoadItem item, bool force){}
}
