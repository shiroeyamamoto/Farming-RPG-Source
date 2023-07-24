using UnityEngine;

public abstract class SingletonMonobehavior<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            return instance;
        }
    }

    //kiểm tra Singleton đã tồn tại chưa, nếu chưa tồn tại thì tạo, còn nếu có rồi thì xóa đối tượng truyền vào
    //Điều này đảm bảo rằng trong khi chạy hệ thống chỉ có duy nhất 1 Singleton tồn tại trong mọi thời điểm
    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}