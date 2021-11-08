using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartySharingManager : MonoBehaviour
{
    public GameObject enterSharingRoomButton, sharingRoomNameText, sharingRoomInputField, sendPartyButton;

    public NetworkedClient networkedClient;
    void Start()
    {
        networkedClient = GetComponent<NetworkedClient>();
        enterSharingRoomButton.GetComponent<Button>().onClick.AddListener(JoinSharingRoomButtonPressed);
        sendPartyButton.GetComponent<Button>().onClick.AddListener(SendPartyButtonPressed);
    }

    private void JoinSharingRoomButtonPressed()
    {
        networkedClient.SendMessageToHost($"{ClientToServerSignifiers.JoinSharingRoom},{sharingRoomInputField.GetComponent<InputField>().text}");
    }

    private void SendPartyButtonPressed()
    {

    }
}
