﻿using System;

namespace Myxomatosis.Connection.Message
{
    public interface IRabbitMessageModel
    {
        void Acknowledge();

        void Error();

        void Error(Exception exception);

        void Reject();
    }
}