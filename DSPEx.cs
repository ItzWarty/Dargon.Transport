﻿namespace Dargon.Transport
{
   public enum DSPEx : byte
   {
      //-------------------------------------------------------------------------------------------
      // Transaction Flow
      //-------------------------------------------------------------------------------------------
      OK                                       = 0x00,
      DONE                                     = OK,
      CONTINUE                                 = 0x01,

      //-------------------------------------------------------------------------------------------
      // S2C Event Opcodes
      //-------------------------------------------------------------------------------------------
      S2C_DIM_RUN_TASKS                        = 0xA1,
      S2C_EVENT_QUIT                           = 0xE0,
      S2C_EVENT_RESOURCES_RELOAD               = 0xE1,

      //-------------------------------------------------------------------------------------------
      // C2S Event Opcodes
      //-------------------------------------------------------------------------------------------
      C2S_META_GET_DARGON_VERSION              = 0x10,

      C2S_MOD_LS_ROOT                          = 0x50,

      C2S_CONSOLE_OPEN                         = 0x70,
      C2S_CONSOLE_WRITELINE                    = 0x71,
      C2S_CONSOLE_CLOSE                        = 0x79,

      C2S_REMOTE_LOG                           = 0x80,

      C2S_ECHO                                 = 0xFE,
      C2S_EVENT_QUIT                           = 0xFF,
   }
}