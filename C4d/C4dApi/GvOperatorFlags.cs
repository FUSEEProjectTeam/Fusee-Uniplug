/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public enum GvOperatorFlags {
  GV_OPERATORFLAG_NONE = (0),
  GV_OPERATORFLAG_MP_SAVE = (1 << 0),
  GV_OPERATORFLAG_READ_ONLY_SAVE = (1 << 1),
  GV_OPERATORFLAG_MULTIPLE_DRAW = (1 << 2),
  GV_OPERATORFLAG_REFRESH_ON_DELETE = (1 << 3),
  GV_OPERATORFLAG_ITERATOR = (1 << 4),
  GV_OPERATORFLAG_SAVE = (GV_OPERATORFLAG_MP_SAVE|GV_OPERATORFLAG_READ_ONLY_SAVE)
}

}
