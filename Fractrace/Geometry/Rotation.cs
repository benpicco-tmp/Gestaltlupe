﻿using System;
using System.Collections.Generic;
using System.Text;

using Fractrace.Basic;

namespace Fractrace.Geometry
{

    /// <summary>
    /// Used for compatibility to old Gestallupe scenes.
    /// </summary>
    public class Rotation : Transform3D
    {


        protected double CenterX = 0;

        protected double CenterY = 0;

        protected double CenterZ = 0;

        protected double AngleX = 0;

        protected double AngleY = 0;

        protected double AngleZ = 0;


        /// <summary>
        /// Initialisation.
        /// </summary>
        public void Init(double centerX, double centerY, double centerZ, double angleX, double angleY, double angleZ)
        {
            CenterX = centerX;
            CenterY = centerY;
            CenterZ = centerZ;
            AngleX = angleX;
            AngleY = angleY;
            AngleZ = angleZ;
        }


        public override Vec3 Transform(Vec3 input)
        {
            double x = input.X;
            double y = input.Y;
            double z = input.Z;

            /* Einbeziehung des Winkels  */
            double f = Math.PI / 180.0;

            // Drehung
            x -= CenterX; y -= CenterY; z -= CenterZ;
            double re = Math.Cos(AngleZ * f);
            double im = Math.Sin(AngleZ * f);
            double a = re * x - im * y;
            y = re * y + im * x;
            x = a;

            // Neigung
            re = Math.Cos(AngleY * f); im = Math.Sin(AngleY * f);
            a = re * z - im * x;
            x = re * x + im * z;
            z = a;

            // Kippen
            re = Math.Cos(AngleX * f); im = Math.Sin(AngleX * f);
            a = re * y - im * z;
            z = re * z + im * y;
            y = a;
            x += CenterX; y += CenterY; z += CenterZ;

            return new Vec3(x, y, z);
        }


        /// <summary>
        /// Like Transform, but with different angle combination.
        /// </summary>
        public Vec3 TransformForNavigation(Vec3 input)
        {

            double x = input.X;
            double y = input.Y;
            double z = input.Z;

            /* Einbeziehung des Winkels  */
            double f = Math.PI / 180.0;
            double re = 0, im = 0, a = 0;

            x -= CenterX; y -= CenterY; z -= CenterZ;

            // Kippen
            re = Math.Cos(AngleX * f); im = Math.Sin(AngleX * f);
            a = re * y - im * z;
            z = re * z + im * y;
            y = a;

            // Neigung
            re = Math.Cos(AngleY * f); im = Math.Sin(AngleY * f);
            a = re * z - im * x;
            x = re * x + im * z;
            z = a;

            // Drehung
            re = Math.Cos(AngleZ * f);
            im = Math.Sin(AngleZ * f);
            a = re * x - im * y;
            y = re * y + im * x;
            x = a;

            x += CenterX; y += CenterY; z += CenterZ;

            return new Vec3(x, y, z);
        }


    }
}
