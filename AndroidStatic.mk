BASE_PATH := $(call my-dir)
include $(CLEAR_VARS)

LOCAL_MODULE := staticmono
LOCAL_MODULE_CLASS := EXECUTABLES

base_intermediates := $(call local-intermediates-dir)

# Using := here prevents recursive expansion
MONO_SRC_FILES :=

# Build libeglib
d := /mono/eglib/src/
LOCAL_PATH := $(BASE_PATH)/$d
intermediates := $(base_intermediates)/$d
# ../config.h and eglib-config.h are both generated by configure
LOCAL_SRC_FILES := 	garray.c gerror.c ghashtable.c gmem.c goutput.c \
	gstr.c gslist.c gstring.c gptrarray.c glist.c gqueue.c gpath.c \
	gshell.c gspawn.c gfile.c gfile-posix.c gpattern.c gmarkup.c \
	gutf8.c gunicode.c gdate-unix.c gdir-unix.c gfile-unix.c \
	gmisc-unix.c gmodule-unix.c gtimer-unix.c 
MONO_SRC_FILES += $(addprefix $d/,$(LOCAL_SRC_FILES))


# Build libmonoutils
d := /mono/mono/utils/
LOCAL_PATH := $(BASE_PATH)/$d
intermediates := $(base_intermediates)/$d
LOCAL_SRC_FILES := mono-ehash.c mono-md5.c \
	mono-sha1.c mono-logger.c mono-codeman.c dlmalloc.h dlmalloc.c \
	mono-counters.c mono-compiler.h mono-dl.c mono-dl.h \
	mono-internal-hash.c mono-internal-hash.h \
	mono-io-portability.c mono-io-portability.h monobitset.c \
	mono-math.c mono-mmap.c mono-mmap.h mono-proclib.c \
	mono-proclib.h mono-time.c mono-time.h strtod.h strtod.c \
	strenc.h strenc.c mono-uri.c mono-poll.c mono-path.c \
	mono-stdlib.c mono-property-hash.h mono-property-hash.c \
	mono-value-hash.h mono-value-hash.c freebsd-elf_common.h \
	freebsd-elf32.h freebsd-elf64.h freebsd-dwarf.h dtrace.h \
	mono-filemap.c
MONO_SRC_FILES += $(addprefix $d/,$(LOCAL_SRC_FILES))


# Build libmonoruntime
d := /mono/mono/metadata/
LOCAL_PATH := $(BASE_PATH)/$d
intermediates := $(base_intermediates)/$d
LOCAL_SRC_FILES := \
	reflection.c	\
	object.c	\
	object-internals.h	\
	icall.c		\
	icall-def.h		\
	char-conversions.h \
	decimal.c	\
	decimal.h	\
	boehm-gc.c	\
	null-gc.c	\
	sgen-gc.c	\
	sgen-gc.h	\
	gc.c		\
	gc-internal.h	\
	method-builder.h \
	method-builder.c \
	marshal.c	\
	marshal.h	\
	mono-mlist.c	\
	mono-mlist.h	\
	monitor.c	\
	monitor.h	\
	tabledefs.h \
	threads.c	\
	threads-types.h	\
	threadpool.c	\
	threadpool.h	\
	threadpool-internals.h	\
	file-io.c	\
	file-io.h	\
	socket-io.c	\
	socket-io.h	\
	exception.c	\
	exception.h	\
	appdomain.c	\
	debug-mono-symfile.h	\
	debug-mono-symfile.c	\
	mono-debug.h		\
	mono-debug.c		\
	mono-debug-debugger.h	\
	mono-debug-debugger.c	\
	profiler.c	\
	profiler-private.h	\
	attach.h	\
	attach.c	\
	rand.h		\
	rand.c		\
	security.c	\
	security.h	\
	security-core-clr.c	\
	security-core-clr.h	\
	string-icalls.c \
	string-icalls.h \
	sysmath.h	\
	sysmath.c	\
	process.c	\
	process.h	\
	environment.c	\
	environment.h	\
	locales.c	\
	locales.h	\
	normalization-tables.h	\
	filewatcher.c	\
	filewatcher.h	\
	culture-info.h  \
	culture-info-tables.h	\
	security-manager.c	\
	security-manager.h	\
	console-io.h	\
	console-io.c \
	assembly.c	\
	coree.c \
	coree.h \
	domain.c	\
	domain-internals.h	\
	opcodes.c	\
	image.c		\
	cil-coff.h	\
	metadata.c	\
	metadata-internals.h	\
	number-formatter.h	\
	verify.c	\
	verify-internals.h	\
	mono-endian.c	\
	mono-endian.h	\
	mono-config.c	\
	loader.c	\
	class.c		\
	class-internals.h		\
	wrapper-types.h		\
	mempool.c	\
	mono-perfcounters.c	\
	mono-perfcounters.h	\
	mono-perfcounters-def.h	\
	debug-helpers.c	\
	generic-sharing.c	\
	mempool-internals.h \
	cominterop.c \
	metadata-verify.c
MONO_SRC_FILES += $(addprefix $d/,$(LOCAL_SRC_FILES))


# Build libwapi
d := /mono/mono/io-layer/
LOCAL_PATH := $(BASE_PATH)/$d
intermediates := $(base_intermediates)/$d

LOCAL_SRC_FILES := access.h atomic.c atomic.h collection.c \
	collection.h context.c context.h critical-sections.c \
	critical-sections.h critical-section-private.h error.c error.h \
	events.c events.h event-private.h handles.c handles.h \
	handles-private.h io.c io.h io-portability.c io-portability.h \
	io-private.h io-layer.h macros.h messages.c messages.h misc.c \
	misc-private.h mutexes.c mutexes.h mutex-private.h \
	mono-mutex.c mono-mutex.h mono-spinlock.h processes.c \
	processes.h process-private.h security.c security.h \
	semaphores.c semaphores.h semaphore-private.h shared.c \
	shared.h sockets.c sockets.h socket-private.h \
	socket-wrappers.h status.h system.c system.h threads.c \
	threads.h thread-private.h timefuncs.c timefuncs.h \
	timefuncs-private.h types.h uglify.h versioninfo.c \
	versioninfo.h wait.c wait.h wapi_glob.h wapi_glob.c
MONO_SRC_FILES += $(addprefix $d/,$(LOCAL_SRC_FILES))


# Build libgc
d := /mono/libgc/
LOCAL_PATH := $(BASE_PATH)/$d
intermediates := $(base_intermediates)/$d

LOCAL_SRC_FILES := allchblk.c alloc.c blacklst.c \
	checksums.c dbg_mlc.c dyn_load.c finalize.c gc_dlopen.c \
	gcj_mlc.c headers.c malloc.c mallocx.c mark.c mark_rts.c \
	misc.c new_hblk.c obj_map.c os_dep.c pcr_interface.c \
	ptr_chck.c real_malloc.c reclaim.c solaris_pthreads.c \
	solaris_threads.c specific.c stubborn.c typd_mlc.c backgraph.c \
	win32_threads.c pthread_support.c pthread_stop_world.c \
	darwin_stop_world.c mach_dep.c
MONO_SRC_FILES += $(addprefix $d/,$(LOCAL_SRC_FILES))


# Build libmono
d := /mono/mono/mini/
LOCAL_PATH := $(BASE_PATH)/$d
intermediates := $(base_intermediates)/$d

# ../config.h, arm_dpimacros.h, version.h and cpu-arm.h are generated by configure
LOCAL_SRC_FILES := mini.c method-to-ir.c \
	decompose.c \
	jit-icalls.c trace.c \
	mini-arch.h dominators.c cfold.c regalloc.c \
	helpers.c liveness.c ssa.c abcremoval.c ssapre.c \
	local-propagation.c driver.c debug-mini.c \
	linear-scan.c aot-compiler.c aot-runtime.c \
	graph.c mini-exceptions.c mini-codegen.c mini-trampolines.c \
	declsec.c wapihandles.c branch-opts.c \
	mini-generic-sharing.c regalloc2.c simd-intrinsics.c \
	unwind.h unwind.c mini-posix.c \
	mini-arm.c exceptions-arm.c tramp-arm.c image-writer.c \
	dwarfwriter.c 
MONO_SRC_FILES += $(addprefix $d/,$(LOCAL_SRC_FILES))

LOCAL_PATH := $(BASE_PATH)

# Disable all warnings
# Must have no optimizations or floating point messes up...?
LOCAL_CFLAGS += -O0 -w
# Force ARM
LOCAL_ARM_MODE := arm
# Eglib stuff
LOCAL_CFLAGS += -DHAVE_PWD_H -DHAVE_UNISTD_H
# Libgc stuff
LOCAL_CFLAGS +=	-DGC_LINUX_THREADS=1 -D_REENTRANT=1 -DSTDC_HEADERS=1 -DHAVE_SYS_TYPES_H=1 -DHAVE_SYS_STAT_H=1 -DHAVE_STDLIB_H=1 -DHAVE_STRING_H=1 -DHAVE_MEMORY_H=1 -DHAVE_STRINGS_H=1 -DHAVE_INTTYPES_H=1 -DHAVE_STDINT_H=1 -DHAVE_UNISTD_H=1 -DHAVE_DLFCN_H=1 -DSILENT=1 -DNO_SIGNALS=1 -DNO_EXECUTE_PERMISSION=1 -DJAVA_FINALIZATION=1 -DGC_GCJ_SUPPORT=1 -DATOMIC_UNCOLLECTABLE=1 -D_IN_LIBGC=1  -DGC_LINUX_THREADS -D_GNU_SOURCE -D_REENTRANT -DUSE_MMAP -DUSE_MUNMAP -D_FILE_OFFSET_BITS=64 -DNO_UNALIGNED_ACCESS
# Mono specific defines
LOCAL_CFLAGS += -DGC_GCJ_SUPPORT=1 -DHAVE_CONFIG_H -DARM_FPU_NONE -DPLATFORM_ANDROID -DMONO_ASSEMBLIES=\"/data/data/com.koushikdutta.mono/assets/lib/\" -DMONO_BINDIR=\"/data/data/com.koushikdutta.mono/assets/bin/\" -DMONO_CFG_DIR=\"/data/data/com.koushikdutta.mono/assets/bin/\"
# libc holes
LOCAL_CFLAGS += -DS_IWRITE=0200

LOCAL_C_INCLUDES += \
	$(BASE_PATH)/PlatformPatches/ \
	$(BASE_PATH)/mono/ \
	$(BASE_PATH)/mono/mono/ \
	$(BASE_PATH)/mono/eglib/src/ \
	$(BASE_PATH)/mono/mono/mini/ \
	$(BASE_PATH)/mono/libgc/include/ \
	$(JNI_H_INCLUDE) 

d := /mono/mono/mini/
LOCAL_PATH := $(BASE_PATH)/$d
intermediates := $(base_intermediates)/$d
LOCAL_SRC_FILES := main.c
MONO_SRC_FILES += $(addprefix $d/,$(LOCAL_SRC_FILES))

LOCAL_PATH := $(BASE_PATH)
LOCAL_SRC_FILES := $(MONO_SRC_FILES)
# missing functions..
LOCAL_SRC_FILES += PlatformPatches/missing.c
# JNI
LOCAL_SRC_FILES += MonoDalvikInterop/com_koushikdutta_monodalvikbridge_MonoBridge.cpp MonoDalvikInterop/bridge.c

# Disable all warnings
# Must have no optimizations or floating point messes up...?
LOCAL_CFLAGS += -O0 -w
# Force ARM
LOCAL_ARM_MODE := arm
# Eglib stuff
LOCAL_CFLAGS += -DHAVE_PWD_H -DHAVE_UNISTD_H
# Libgc stuff
LOCAL_CFLAGS +=	-DGC_LINUX_THREADS=1 -D_REENTRANT=1 -DSTDC_HEADERS=1 -DHAVE_SYS_TYPES_H=1 -DHAVE_SYS_STAT_H=1 -DHAVE_STDLIB_H=1 -DHAVE_STRING_H=1 -DHAVE_MEMORY_H=1 -DHAVE_STRINGS_H=1 -DHAVE_INTTYPES_H=1 -DHAVE_STDINT_H=1 -DHAVE_UNISTD_H=1 -DHAVE_DLFCN_H=1 -DSILENT=1 -DNO_SIGNALS=1 -DNO_EXECUTE_PERMISSION=1 -DJAVA_FINALIZATION=1 -DGC_GCJ_SUPPORT=1 -DATOMIC_UNCOLLECTABLE=1 -D_IN_LIBGC=1  -DGC_LINUX_THREADS -D_GNU_SOURCE -D_REENTRANT -DUSE_MMAP -DUSE_MUNMAP -D_FILE_OFFSET_BITS=64 -DNO_UNALIGNED_ACCESS
# Mono specific defines
LOCAL_CFLAGS += -DGC_GCJ_SUPPORT=1 -DHAVE_CONFIG_H -DARM_FPU_NONE -DPLATFORM_ANDROID -DMONO_ASSEMBLIES=\"/data/data/com.koushikdutta.mono/assets/lib/\" -DMONO_BINDIR=\"/data/data/com.koushikdutta.mono/assets/bin/\" -DMONO_CFG_DIR=\"/data/data/com.koushikdutta.mono/assets/bin/\"
# libc holes
LOCAL_CFLAGS += -DS_IWRITE=0200

LOCAL_C_INCLUDES += \
	$(BASE_PATH)/PlatformPatches/ \
	$(BASE_PATH)/mono/ \
	$(BASE_PATH)/mono/mono/ \
	$(BASE_PATH)/mono/eglib/src/ \
	$(BASE_PATH)/mono/mono/mini/ \
	$(BASE_PATH)/mono/libgc/include/ 
 

LOCAL_PRELINK_MODULE := false
LOCAL_SHARED_LIBRARIES += libdl libc libm 
LOCAL_SHARED_LIBRARIES += libdl libc libm libdvm libnativehelper liblog
include $(BUILD_EXECUTABLE)


