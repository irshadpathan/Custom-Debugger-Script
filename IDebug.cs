// *********** Developer Irshad Khan : http://www.irshadkhan.info ************** Open source license **************//



/// <summary>
/// Debug massage while development a game
/// </summary>
public sealed class IDebug
{
	
	/// <summary>
	/// Log the specified massage.
	/// </summary>
	/// <param name="massage">Massage.</param>
	public static  void Log(string massage){UnityEngine.Debug.Log("<color=#00ff00ff>"+"<b>"+massage+"</b>"+"</color>");}


	/// <summary>
	/// Log the specified massage and Break.
	/// </summary>
	/// <param name="massage">Massage.</param>
	/// <param name="Break">If set to <c>true</c> break.</param>
	public static  void Log(string massage,bool Break){UnityEngine.Debug.Log ("<color=#00ff00ff>"+"<b>" + massage +"</b>"+ "</color>");if (Break)
				UnityEngine.Debug.Break ();}


	/// <summary>
	/// Logs the error.
	/// </summary>
	/// <param name="massage">Massage.</param>
	public static  void LogError(string massage){UnityEngine.Debug.Log("<color=#ff0000ff>"+"<b>"+massage+"</b>"+"</color>");}

	/// <summary>
	/// Logs the error.
	/// </summary>
	/// <param name="massage">Massage.</param>
	/// <param name="Break">If set to <c>true</c> break.</param>
	public static  void LogError(string massage,bool Break){UnityEngine.Debug.Log ("<color=#ff0000ff>"+"<b>" + massage +"</b>" +"</color>");if (Break)
			UnityEngine.Debug.Break ();}

	/// <summary>
	/// Logs the warning.
	/// </summary>
	/// <param name="massage">Massage.</param>
	public static void LogWarning(string massage){UnityEngine.Debug.Log("<color=#ffff00ff>"+"<b>"+massage+"</b>"+"</color>");}


	/// <summary>
	/// Logs the warning.
	/// </summary>
	/// <param name="massage">Massage.</param>
	/// <param name="Break">If set to <c>true</c> break.</param>
	public static  void LogWarning(string massage,bool Break){UnityEngine.Debug.Log ("<color=#ffff00ff>"+"<b>" + massage +"</b>" +"</color>");if (Break)
			UnityEngine.Debug.Break ();}

}

