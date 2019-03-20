﻿// Copyright (c) Amer Koleci and contributors.
// Distributed under the MIT license. See the LICENSE file in the project root for more information.

namespace HelloDirect3D11
{
    public static class Program
    {
        private class TestApplication : Application
        {
            public TestApplication(bool useDirect3D12)
                : base(useDirect3D12)
            {
            }
        }

        public static void Main()
        {
            using (var app = new TestApplication(useDirect3D12: false))
            {
                app.Run();
            }
        }
    }
}
