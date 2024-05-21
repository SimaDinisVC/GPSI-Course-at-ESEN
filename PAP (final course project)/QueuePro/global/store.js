import { configureStore } from '@reduxjs/toolkit'
import globalVARSlice from './stateSlices/globalVariables'
import ticketsSlice from './stateSlices/ticketsSlice'
import companySlice from './stateSlices/companySlice'
import establishmentSlice from './stateSlices/establishmentSlice'
import sectionSlice from './stateSlices/sectionSlice'
import availableQueuesSlice from './stateSlices/availableQueues'

export default configureStore({
  reducer: {
    globalVARS: globalVARSlice,
    tickets: ticketsSlice,
    companys: companySlice,
    establishments: establishmentSlice,
    sections: sectionSlice,
    availableQueues: availableQueuesSlice
  }
})