using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "AudioManager", menuName = "ScriptableObjects/AudioManager")]
public class AudioManager : ScriptableObject
{
    public string uniqueID;
    public List<AudioClipData> audioClips = new List<AudioClipData>();
    [TextArea(3, 10)]
    public string longText;
}
[System.Serializable]
public class AudioClipData
{
    public AudioClip audioClip;
    [Range(0f, 1f)]
    public float volume;
}