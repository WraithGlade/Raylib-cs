/*******************************************************************************************
*
*   raylib [shapes] example - Draw basic shapes 2d (rectangle, circle, line...)
*
*   This example has been created using raylib 1.0 (www.raylib.com)
*   raylib is licensed under an unmodified zlib/libpng license (View raylib.h for details)
*
*   Copyright (c) 2014 Ramon Santamaria (@raysan5)
*
********************************************************************************************/

using System.Numerics;
using static Raylib_cs.Raylib;

namespace Examples.Shapes;

public class BasicShapes
{
    public static int Main()
    {
        // Initialization
        //--------------------------------------------------------------------------------------
        const int screenWidth = 800;
        const int screenHeight = 450;

        InitWindow(screenWidth, screenHeight, "raylib [shapes] example - basic shapes drawing");

        SetTargetFPS(60);
        //--------------------------------------------------------------------------------------

        // Main game loop
        while (!WindowShouldClose())
        {
            // Update
            //----------------------------------------------------------------------------------
            // TODO: Update your variables here
            //----------------------------------------------------------------------------------

            // Draw
            //----------------------------------------------------------------------------------
            BeginDrawing();
            ClearBackground(Color.RAYWHITE);

            DrawText("some basic shapes available on raylib", 20, 20, 20, Color.DARKGRAY);

            DrawLine(18, 42, screenWidth - 18, 42, Color.BLACK);

            DrawCircle(screenWidth / 4, 120, 35, Color.DARKBLUE);
            DrawCircleGradient(screenWidth / 4, 220, 60, Color.GREEN, Color.SKYBLUE);
            DrawCircleLines(screenWidth / 4, 340, 80, Color.DARKBLUE);

            DrawRectangle(screenWidth / 4 * 2 - 60, 100, 120, 60, Color.RED);
            DrawRectangleGradientH(screenWidth / 4 * 2 - 90, 170, 180, 130, Color.MAROON, Color.GOLD);
            DrawRectangleLines(screenWidth / 4 * 2 - 40, 320, 80, 60, Color.ORANGE);

            DrawTriangle(
                new Vector2(screenWidth / 4 * 3, 80),
                new Vector2(screenWidth / 4 * 3 - 60, 150),
                new Vector2(screenWidth / 4 * 3 + 60, 150), Color.VIOLET
            );

            DrawTriangleLines(
                new Vector2(screenWidth / 4 * 3, 160),
                new Vector2(screenWidth / 4 * 3 - 20, 230),
                new Vector2(screenWidth / 4 * 3 + 20, 230), Color.DARKBLUE
            );

            DrawPoly(new Vector2(screenWidth / 4 * 3, 320), 6, 80, 0, Color.BROWN);

            EndDrawing();
            //----------------------------------------------------------------------------------
        }

        // De-Initialization
        //--------------------------------------------------------------------------------------
        CloseWindow();
        //--------------------------------------------------------------------------------------

        return 0;
    }
}
