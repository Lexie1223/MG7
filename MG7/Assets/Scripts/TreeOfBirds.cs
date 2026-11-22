using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!public class TreeOfBirds : MonoBehaviour
public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private GameObject[] birds;
    [SerializeField] private Transform player;
    [SerializeField] private float interactionDistance = 5f;

    void Update()
    {
        foreach (GameObject bird in birds)
        {
            if (bird == null) continue;

            float distance = Vector3.Distance(
                player.position,
                bird.transform.position
            );

            if (distance <= interactionDistance)
            {
                bird.SetActive(true);
            }
        }
    }
}

