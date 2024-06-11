

class Snake : Panel
{

    public static List<KeyValuePair<Panel, Status>> SnakeBody = new List<KeyValuePair<Panel, Status>>();
    public static void Add(Panel panel, Status status)
    {
        KeyValuePair<Panel, Status> keyValue = new KeyValuePair<Panel, Status>(panel, status);
       SnakeBody.Add(keyValue);
    }

}

