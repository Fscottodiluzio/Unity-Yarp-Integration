//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class BufferedPortImageInt : Contactable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal BufferedPortImageInt(global::System.IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.BufferedPortImageInt_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BufferedPortImageInt obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BufferedPortImageInt() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_BufferedPortImageInt(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public BufferedPortImageInt() : this(yarpPINVOKE.new_BufferedPortImageInt__SWIG_0(), true) {
  }

  public BufferedPortImageInt(Port port) : this(yarpPINVOKE.new_BufferedPortImageInt__SWIG_1(Port.getCPtr(port)), true) {
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool addOutput(string name) {
    bool ret = yarpPINVOKE.BufferedPortImageInt_addOutput__SWIG_0(swigCPtr, name);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool addOutput(string name, string carrier) {
    bool ret = yarpPINVOKE.BufferedPortImageInt_addOutput__SWIG_1(swigCPtr, name, carrier);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool addOutput(Contact contact) {
    bool ret = yarpPINVOKE.BufferedPortImageInt_addOutput__SWIG_2(swigCPtr, Contact.getCPtr(contact));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void close() {
    yarpPINVOKE.BufferedPortImageInt_close(swigCPtr);
  }

  public override void interrupt() {
    yarpPINVOKE.BufferedPortImageInt_interrupt(swigCPtr);
  }

  public override void resume() {
    yarpPINVOKE.BufferedPortImageInt_resume(swigCPtr);
  }

  public new int getPendingReads() {
    int ret = yarpPINVOKE.BufferedPortImageInt_getPendingReads(swigCPtr);
    return ret;
  }

  public override Contact where() {
    Contact ret = new Contact(yarpPINVOKE.BufferedPortImageInt_where(swigCPtr), true);
    return ret;
  }

  public override string getName() {
    string ret = yarpPINVOKE.BufferedPortImageInt_getName(swigCPtr);
    return ret;
  }

  public ImageInt prepare() {
    ImageInt ret = new ImageInt(yarpPINVOKE.BufferedPortImageInt_prepare(swigCPtr), false);
    return ret;
  }

  public bool unprepare() {
    bool ret = yarpPINVOKE.BufferedPortImageInt_unprepare(swigCPtr);
    return ret;
  }

  public new void write(bool forceStrict) {
    yarpPINVOKE.BufferedPortImageInt_write__SWIG_0(swigCPtr, forceStrict);
  }

  public new void write() {
    yarpPINVOKE.BufferedPortImageInt_write__SWIG_1(swigCPtr);
  }

  public void writeStrict() {
    yarpPINVOKE.BufferedPortImageInt_writeStrict(swigCPtr);
  }

  public void waitForWrite() {
    yarpPINVOKE.BufferedPortImageInt_waitForWrite(swigCPtr);
  }

  public new void setStrict(bool strict) {
    yarpPINVOKE.BufferedPortImageInt_setStrict__SWIG_0(swigCPtr, strict);
  }

  public new void setStrict() {
    yarpPINVOKE.BufferedPortImageInt_setStrict__SWIG_1(swigCPtr);
  }

  public new ImageInt read(bool shouldWait) {
    global::System.IntPtr cPtr = yarpPINVOKE.BufferedPortImageInt_read__SWIG_0(swigCPtr, shouldWait);
    ImageInt ret = (cPtr == global::System.IntPtr.Zero) ? null : new ImageInt(cPtr, false);
    return ret;
  }

  public new ImageInt read() {
    global::System.IntPtr cPtr = yarpPINVOKE.BufferedPortImageInt_read__SWIG_1(swigCPtr);
    ImageInt ret = (cPtr == global::System.IntPtr.Zero) ? null : new ImageInt(cPtr, false);
    return ret;
  }

  public new ImageInt lastRead() {
    global::System.IntPtr cPtr = yarpPINVOKE.BufferedPortImageInt_lastRead(swigCPtr);
    ImageInt ret = (cPtr == global::System.IntPtr.Zero) ? null : new ImageInt(cPtr, false);
    return ret;
  }

  public new bool isClosed() {
    bool ret = yarpPINVOKE.BufferedPortImageInt_isClosed(swigCPtr);
    return ret;
  }

  public new void setReplier(PortReader reader) {
    yarpPINVOKE.BufferedPortImageInt_setReplier(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setReader(PortReader reader) {
    yarpPINVOKE.BufferedPortImageInt_setReader(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setAdminReader(PortReader reader) {
    yarpPINVOKE.BufferedPortImageInt_setAdminReader(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void onRead(ImageInt datum) {
    yarpPINVOKE.BufferedPortImageInt_onRead(swigCPtr, ImageInt.getCPtr(datum));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void useCallback(TypedReaderCallbackImageInt callback) {
    yarpPINVOKE.BufferedPortImageInt_useCallback__SWIG_0(swigCPtr, TypedReaderCallbackImageInt.getCPtr(callback));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void useCallback() {
    yarpPINVOKE.BufferedPortImageInt_useCallback__SWIG_1(swigCPtr);
  }

  public virtual void disableCallback() {
    yarpPINVOKE.BufferedPortImageInt_disableCallback(swigCPtr);
  }

  public override bool setEnvelope(PortWriter envelope) {
    bool ret = yarpPINVOKE.BufferedPortImageInt_setEnvelope(swigCPtr, PortWriter.getCPtr(envelope));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool getEnvelope(PortReader envelope) {
    bool ret = yarpPINVOKE.BufferedPortImageInt_getEnvelope(swigCPtr, PortReader.getCPtr(envelope));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getInputCount() {
    int ret = yarpPINVOKE.BufferedPortImageInt_getInputCount(swigCPtr);
    return ret;
  }

  public override int getOutputCount() {
    int ret = yarpPINVOKE.BufferedPortImageInt_getOutputCount(swigCPtr);
    return ret;
  }

  public override bool isWriting() {
    bool ret = yarpPINVOKE.BufferedPortImageInt_isWriting(swigCPtr);
    return ret;
  }

  public override void getReport(PortReport reporter) {
    yarpPINVOKE.BufferedPortImageInt_getReport(swigCPtr, PortReport.getCPtr(reporter));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setReporter(PortReport reporter) {
    yarpPINVOKE.BufferedPortImageInt_setReporter(swigCPtr, PortReport.getCPtr(reporter));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_void acquire() {
    global::System.IntPtr cPtr = yarpPINVOKE.BufferedPortImageInt_acquire(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public virtual void release(SWIGTYPE_p_void handle) {
    yarpPINVOKE.BufferedPortImageInt_release(swigCPtr, SWIGTYPE_p_void.getCPtr(handle));
  }

  public new void setTargetPeriod(double period) {
    yarpPINVOKE.BufferedPortImageInt_setTargetPeriod(swigCPtr, period);
  }

  public override SWIGTYPE_p_Type getType() {
    SWIGTYPE_p_Type ret = new SWIGTYPE_p_Type(yarpPINVOKE.BufferedPortImageInt_getType(swigCPtr), true);
    return ret;
  }

  public override void promiseType(SWIGTYPE_p_Type typ) {
    yarpPINVOKE.BufferedPortImageInt_promiseType(swigCPtr, SWIGTYPE_p_Type.getCPtr(typ));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setInputMode(bool expectInput) {
    yarpPINVOKE.BufferedPortImageInt_setInputMode(swigCPtr, expectInput);
  }

  public override void setOutputMode(bool expectOutput) {
    yarpPINVOKE.BufferedPortImageInt_setOutputMode(swigCPtr, expectOutput);
  }

  public override void setRpcMode(bool expectRpc) {
    yarpPINVOKE.BufferedPortImageInt_setRpcMode(swigCPtr, expectRpc);
  }

  public override Property acquireProperties(bool readOnly) {
    global::System.IntPtr cPtr = yarpPINVOKE.BufferedPortImageInt_acquireProperties(swigCPtr, readOnly);
    Property ret = (cPtr == global::System.IntPtr.Zero) ? null : new Property(cPtr, false);
    return ret;
  }

  public override void releaseProperties(Property prop) {
    yarpPINVOKE.BufferedPortImageInt_releaseProperties(swigCPtr, Property.getCPtr(prop));
  }

  public override void includeNodeInName(bool flag) {
    yarpPINVOKE.BufferedPortImageInt_includeNodeInName(swigCPtr, flag);
  }

  public override bool setCallbackLock(SWIGTYPE_p_yarp__os__Mutex mutex) {
    bool ret = yarpPINVOKE.BufferedPortImageInt_setCallbackLock(swigCPtr, SWIGTYPE_p_yarp__os__Mutex.getCPtr(mutex));
    return ret;
  }

  public override bool removeCallbackLock() {
    bool ret = yarpPINVOKE.BufferedPortImageInt_removeCallbackLock(swigCPtr);
    return ret;
  }

  public override bool lockCallback() {
    bool ret = yarpPINVOKE.BufferedPortImageInt_lockCallback(swigCPtr);
    return ret;
  }

  public override bool tryLockCallback() {
    bool ret = yarpPINVOKE.BufferedPortImageInt_tryLockCallback(swigCPtr);
    return ret;
  }

  public override void unlockCallback() {
    yarpPINVOKE.BufferedPortImageInt_unlockCallback(swigCPtr);
  }

}
