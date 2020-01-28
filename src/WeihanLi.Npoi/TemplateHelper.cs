﻿using System;
using WeihanLi.Extensions;

namespace WeihanLi.Npoi
{
    public class TemplateOptions
    {
        private string _templateGlobalParamFormat = InternalConstants.TemplateGlobalParamFormat;
        private string _templateHeaderParamFormat = InternalConstants.TemplateHeaderParamFormat;
        private string _templateDataParamFormat = InternalConstants.TemplateDataParamFormat;
        private string _templateDataPrefix = InternalConstants.TemplateDataPrefix;
        private string _templateDataBegin = InternalConstants.TemplateDataBegin;
        private string _templateDataEnd = InternalConstants.TemplateDataEnd;

        public string TemplateGlobalParamFormat
        {
            get => _templateGlobalParamFormat;
            set
            {
                if (value.IsNotNullOrWhiteSpace())
                    _templateGlobalParamFormat = value;
            }
        }

        public string TemplateHeaderParamFormat
        {
            get => _templateHeaderParamFormat;
            set
            {
                if (value.IsNotNullOrWhiteSpace())
                    _templateHeaderParamFormat = value;
            }
        }

        public string TemplateDataParamFormat
        {
            get => _templateDataParamFormat;
            set
            {
                if (value.IsNotNullOrWhiteSpace())
                    _templateDataParamFormat = value;
            }
        }

        public string TemplateDataPrefix
        {
            get => _templateDataPrefix;
            set
            {
                if (value.IsNotNullOrWhiteSpace())
                    _templateDataPrefix = value;
            }
        }

        public string TemplateDataBegin
        {
            get => _templateDataBegin;
            set
            {
                if (value.IsNotNullOrWhiteSpace())
                    _templateDataBegin = value;
            }
        }

        public string TemplateDataEnd
        {
            get => _templateDataEnd;
            set
            {
                if (value.IsNotNullOrWhiteSpace())
                    _templateDataEnd = value;
            }
        }
    }

    public static class TemplateHelper
    {
        public static void ConfigureTemplateOptions(Action<TemplateOptions> optionsAction)
        {
            if (null == optionsAction)
            {
                throw new ArgumentNullException(nameof(optionsAction));
            }
            optionsAction.Invoke(NpoiTemplateHelper.TemplateOptions);
        }
    }
}