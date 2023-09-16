using UnityEngine;

public class TriggerObscuringItemFader : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Lấy tất cả các gameObject mà ta collision, sau đó lấy tất cả các Obscuring Item Component của nó và con của nó - và sau đó trigger fade out

        ObscuringItemFader[] obscuringItemFader = collision.gameObject.GetComponentsInChildren<ObscuringItemFader>();

        if(obscuringItemFader.Length>0)
            foreach (ObscuringItemFader item in obscuringItemFader)
            {
                item.FadeOut();
            }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Lấy tất cả các gameObject mà ta collision, sau đó lấy tất cả các Obscuring Item Component của nó và con của nó - và sau đó trigger fade in

        ObscuringItemFader[] obscuringItemFader = collision.gameObject.GetComponentsInChildren<ObscuringItemFader>();

        if (obscuringItemFader.Length > 0)
            foreach (ObscuringItemFader item in obscuringItemFader)
            {
                item.FadeIn();
            }
    }
}
