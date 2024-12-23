using UnityEngine;
using UnityEngine.UI;

public class AudioManagerUI : MonoBehaviour
{
    public AudioManager audioManager;

    public GameObject listPanel;
    public GameObject textPanel;

    public Text idText;
    public Slider volumeSlider;

    private void Start()
    {
        idText.text = "ID: " + audioManager.uniqueID;
        volumeSlider.onValueChanged.AddListener(OnVolumeChange);
        volumeSlider.value = audioManager.audioClips.Count > 0 ? audioManager.audioClips[0].volume : 0; // ��������� ��������� ������� ����������
    }

    public void ShowList()
        
    {
        listPanel.SetActive(true);
        textPanel.SetActive(false);
        // ����� �� ������ �������� ��� ��� ����������� ������ �����������
    }

    public void ShowText()
    {
        listPanel.SetActive(false);
        textPanel.SetActive(true);
        // ����� �� ������ ���������� ����� � ��������� ����
    }

    public void HideAll()
    {
        listPanel.SetActive(false);
        textPanel.SetActive(false);
    }

    private void OnVolumeChange(float value)
    {
        if (audioManager.audioClips.Count > 0)
        {
            audioManager.audioClips[0].volume = value; // �������� ��������� ������� ����������
        }
    }
}