using System;

namespace MosquitoTrapCount
{
	public interface IHUDService
	{
		void Show (string message = null);
		void Dismiss();
		void ShowError (string message);
	}
}

