namespace FC_Manage_Salary_WIzard.ActionLayer {
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  /// <summary>Класс отвечает за сообщения в системе</summary>
  class Messager {
    private static List<string> Log;
    public delegate void HaveSomethingToSAy(string Message);
    public static event HaveSomethingToSAy Say;

    public delegate void CreateProgress(int Maxvalue, int Value);
    public static event CreateProgress Progress;

    public delegate void StatusSay(string Message);
    public static event StatusSay Status;

    /// <summary>Сообщение в строку статуса </summary>
    /// <param name="message">Текст сообщения</param>
    public static void StatusMessage(string message) {
      Status?.Invoke(message);
    }

    /// <summary>Сообщение в лог </summary>
    /// <param name="message">Текст сообщения</param>
    public static void SayMessage(string message) {
      if(Say!= null) {
        if(Log == null)
          Log = new List<string>();
        Log.Add(DateTime.Now + "\t" + message);
        Say(message);
      }
    }

    public static List<string> ShowLog() {
      return Log;
    }
    /// <summary>Изменение пргресса</summary>
    /// <param name="max">Интовое представление максимального результата</param>
    /// <param name="value">Интовое представление текущего состояния</param>
    public static void ProgressChange(int max, int value) {
      if(Progress != null) {
        Progress(max, value);
      }
    }
  }
}
