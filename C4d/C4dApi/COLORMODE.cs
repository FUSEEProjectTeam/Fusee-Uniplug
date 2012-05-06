/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 0.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public enum COLORMODE {
  COLORMODE_ILLEGAL = 0,
  COLORMODE_ALPHA = 1,
  COLORMODE_GRAY = 2,
  COLORMODE_AGRAY = 3,
  COLORMODE_RGB = 4,
  COLORMODE_ARGB = 5,
  COLORMODE_CMYK = 6,
  COLORMODE_ACMYK = 7,
  COLORMODE_MASK = 8,
  COLORMODE_AMASK = 9,
  COLORMODE_ILLEGALw = (1 << 4),
  COLORMODE_GRAYw = (COLORMODE_GRAY|(1 << 4)),
  COLORMODE_AGRAYw = (COLORMODE_AGRAY|(1 << 4)),
  COLORMODE_RGBw = (COLORMODE_RGB|(1 << 4)),
  COLORMODE_ARGBw = (COLORMODE_ARGB|(1 << 4)),
  COLORMODE_MASKw = (COLORMODE_MASK|(1 << 4)),
  COLORMODE_ILLEGALf = (2 << 4),
  COLORMODE_GRAYf = (COLORMODE_GRAY|(2 << 4)),
  COLORMODE_AGRAYf = (COLORMODE_AGRAY|(2 << 4)),
  COLORMODE_RGBf = (COLORMODE_RGB|(2 << 4)),
  COLORMODE_ARGBf = (COLORMODE_ARGB|(2 << 4)),
  COLORMODE_MASKf = (COLORMODE_MASK|(2 << 4))
}

}
