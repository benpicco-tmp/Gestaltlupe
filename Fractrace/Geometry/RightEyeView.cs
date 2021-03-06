﻿using System;
using System.Collections.Generic;
using System.Text;

using Fractrace.Basic;

namespace Fractrace.Geometry
{

    /// <summary>
    /// Used for stereo rendering.
    /// </summary>
    class RightEyeView : Transform3D
    {


        protected double _eyeDistance = 0.2;

        /// <summary>
        /// Um diesen Wert wird die Ansicht nach rechts verschoben.
        /// </summary>
        protected double _xOffset = 0;

        protected double _yCenter = 0;

        protected double _xCenter = 0;


        /* Einbeziehung des Winkels  */
        // Winkel, um den der Blick nach links gedreht ist
        protected double _stereoAngle = 4.3 * (Math.PI / 180.0);


        /// <summary>
        /// Set fields from current ParameterDict.Exemplar.
        /// </summary>
        public override void Init()
        {
            _eyeDistance = ParameterDict.Current.GetDouble("Transformation.Stereo.EyeDistance");
            _stereoAngle = ParameterDict.Current.GetDouble("Transformation.Stereo.Angle") * (Math.PI / 180.0);
            /*
            _xOffset = _eyeDistance * (ParameterDict.Current.GetDouble("Border.Max.x") - ParameterDict.Current.GetDouble("Border.Min.x"));
            _xCenter = (ParameterDict.Current.GetDouble("Border.Max.x") - ParameterDict.Current.GetDouble("Border.Min.x"));
            _yCenter = (ParameterDict.Current.GetDouble("Border.Max.y") - ParameterDict.Current.GetDouble("Border.Min.y"));
            */
            _xOffset = _eyeDistance * ParameterDict.Current.GetDouble("Scene.Radius");
            // Better use Scene.CenterX, Scene.CenterY ????
            _xCenter = ParameterDict.Current.GetDouble("Scene.Radius");
            _yCenter = ParameterDict.Current.GetDouble("Scene.Radius");



        }


        /// <summary>
        /// Die definierte Koordinatentransformation wird umgesetzt.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override Vec3 Transform(Vec3 input)
        {
            double x = input.X;
            double y = input.Y;
            double z = input.Z;

            x -= _xCenter; y -= _yCenter;
            double re = Math.Cos(_stereoAngle);
            double im = Math.Sin(_stereoAngle);
            double a = re * x - im * y;
            y = re * y + im * x;
            x = a;
            x += _xCenter; y += _yCenter;
            x += _eyeDistance;

            return new Vec3(x, y, z);
        }


    }
}
