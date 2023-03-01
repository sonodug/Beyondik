using UnityEngine;

public class GeneratorInteractiveZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.HandleInteractiveWithGenerator(gameObject.GetComponentInParent<Generator>(), true);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.HandleInteractiveWithGenerator(null, false);
        }
    }
}
