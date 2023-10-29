﻿using System;

namespace GeneralUtils.States {
    public class SubStateMachine<TBaseStateEnum, TStateEnum> : AbstractSubStateMachine<TBaseStateEnum, TStateEnum>
        where TBaseStateEnum : struct, Enum
        where TStateEnum : struct, Enum {
        protected sealed override void OnStateEnterLogic(StateInfo stateInfo = null) {
            PerformStateEnter();
        }

        protected virtual void PerformStateEnter() { }
    }
}
