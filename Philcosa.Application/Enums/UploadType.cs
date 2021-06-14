﻿using System.ComponentModel;

namespace Philcosa.Application.Enums
{
    public enum UploadType
    {
        [Description(@"Images\Covers")]
        Cover,
        [Description(@"Images\Products")]
        Product,

        [Description(@"Images\ProfilePictures")]
        ProfilePicture,

        [Description(@"Documents")]
        Document
    }
}