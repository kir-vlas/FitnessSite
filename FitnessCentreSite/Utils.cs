using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using FitnessCentreSite.Models;

namespace FitnessCentreSite
{
    public enum SessionKey
    {
        CART,
        RETURN_URL
    }
    public class Utils
    {
        public static void Set(HttpSessionStateBase session, SessionKey key, object value)
        {
            session[Enum.GetName(typeof(SessionKey), key)] = value;
        }

        public static T Get<T>(HttpSessionStateBase session, SessionKey key)
        {
            object dataValue = session[Enum.GetName(typeof(SessionKey), key)];
            if (dataValue != null && dataValue is T)
            {
                return (T)dataValue;
            }
            else
            {
                return default(T);
            }
        }

        public static Cart GetCart(HttpSessionStateBase session)
        {
            Cart myCart = Get<Cart>(session, SessionKey.CART);
            if (myCart == null)
            {
                myCart = new Cart();
                Set(session, SessionKey.CART, myCart);
            }
            return myCart;
        }
    }
}